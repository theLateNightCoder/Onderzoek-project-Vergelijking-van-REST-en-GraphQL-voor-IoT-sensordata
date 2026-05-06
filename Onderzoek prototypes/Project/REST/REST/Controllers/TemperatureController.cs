using Microsoft.AspNetCore.Mvc;
using REST.Data;
using REST.Dtos;
using REST.Model;

namespace TempSensorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemperatureController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TemperatureController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> SaveTemperature([FromBody] CreateTemperatureReadingDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.SensorName))
            {
                return BadRequest("SensorName is required.");
            }

            var reading = new TemperatureReading
            {
                SensorName = dto.SensorName,
                TemperatureC = dto.TemperatureC,
                ReadingTimeUtc = dto.ReadingTimeUtc,
                CreatedAtUtc = DateTime.UtcNow
            };

            _context.TemperatureReadings.Add(reading);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Temperature reading saved successfully.",
                id = reading.Id
            });
        }
    }
}