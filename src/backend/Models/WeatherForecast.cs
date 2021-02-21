using System;
using Microsoft.EntityFrameworkCore;

namespace Weather.Models
{

    public class WeatherForecastContext: DbContext
    {
        public WeatherForecastContext(DbContextOptions<WeatherForecastContext> options) : base(options)
        {

        }

        public DbSet<WeatherForecast> weatherForecasts { get; set; }
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        // Computed column in the database
        public int TemperatureF { get; set; }

        public string Summary { get; set; }
    }
}
