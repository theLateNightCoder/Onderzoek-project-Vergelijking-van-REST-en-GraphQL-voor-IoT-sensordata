using GraphQL.Data;
using GraphQL.GraphQL.Types;
using GraphQL.Model;
using HotChocolate;
using HotChocolate.Data;

namespace TempSensorGraphQL.GraphQL.Mutations
{
    public class TemperatureMutations
    {
        public async Task<TemperatureReading> AddTemperatureReadingAsync(
        CreateTemperatureReadingInput input,
        AppDbContext dbContext)   
        {
            var reading = new TemperatureReading
            {
                SensorName = input.SensorName,
                TemperatureC = input.TemperatureC,
                ReadingTimeUtc = input.ReadingTimeUtc,
                CreatedAtUtc = DateTime.UtcNow
            };

            dbContext.TemperatureReadings.Add(reading);
            await dbContext.SaveChangesAsync();

            return reading;
        }

    }
}