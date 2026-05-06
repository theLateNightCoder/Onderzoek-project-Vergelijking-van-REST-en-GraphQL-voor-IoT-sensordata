using GraphQL.Data;
using GraphQL.GraphQL;
using Microsoft.EntityFrameworkCore;
using TempSensorGraphQL.GraphQL.Mutations;

var builder = WebApplication.CreateBuilder(args);

// Normal DbContext registration (no factory)
builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services
    .AddGraphQLServer()
    .RegisterDbContextFactory<AppDbContext>()
    .AddQueryType<Query>()     // at least 1 field required
    .AddMutationType<TemperatureMutations>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();

app.MapGraphQL();

app.Run();