using GraphQL.Model;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<TemperatureReading> TemperatureReadings => Set<TemperatureReading>();
    }
}
