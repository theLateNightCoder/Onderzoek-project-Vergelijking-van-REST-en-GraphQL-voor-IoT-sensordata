using Microsoft.EntityFrameworkCore;
using REST.Model;

namespace REST.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<TemperatureReading> TemperatureReadings => Set<TemperatureReading>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TemperatureReading>(entity =>
            {
                entity.ToTable("TemperatureReadings");

                entity.HasKey(x => x.Id);

                entity.Property(x => x.SensorName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(x => x.TemperatureC)
                    .HasColumnType("decimal(5,2)");

                entity.Property(x => x.ReadingTimeUtc)
                    .IsRequired();

                entity.Property(x => x.CreatedAtUtc)
                    .IsRequired();
            });
        }
    }
}