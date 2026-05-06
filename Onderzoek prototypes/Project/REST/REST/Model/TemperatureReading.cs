namespace REST.Model
{
    public class TemperatureReading
    {
        public int Id { get; set; }

        public string SensorName { get; set; } = string.Empty;

        public decimal TemperatureC { get; set; }

        public DateTime ReadingTimeUtc { get; set; }

        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }
}
