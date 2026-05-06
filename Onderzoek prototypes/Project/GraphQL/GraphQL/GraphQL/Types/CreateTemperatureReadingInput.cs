namespace GraphQL.GraphQL.Types
{
    public class CreateTemperatureReadingInput
    {
        public string SensorName { get; set; } = string.Empty;
        public decimal TemperatureC { get; set; }
        public DateTime ReadingTimeUtc { get; set; }
    }
}
