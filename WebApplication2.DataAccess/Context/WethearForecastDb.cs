using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication2.DataAccess.Context
{
    public class WethearForecastDb : DbContext
    {
        public virtual DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public WethearForecastDb(DbContextOptions<WethearForecastDb> options) : base(options)
        {}
    }
}
