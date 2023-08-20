using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication2.DataAccess.Context
{
    public partial class WeatherForecastDb : DbContext
    {
        public virtual DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public WeatherForecastDb(DbContextOptions<WeatherForecastDb> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<WeatherForecast>()
                .Ignore(x => x.TemperatureF);
              
        }
    }
}
