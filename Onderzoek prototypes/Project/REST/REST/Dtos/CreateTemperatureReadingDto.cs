namespace REST.Dtos
{
    public class CreateTemperatureReadingDto
    {
        public string SensorName { get; set; } = string.Empty;

        public decimal TemperatureC { get; set; }

        public DateTime ReadingTimeUtc { get; set; }
    }
}
