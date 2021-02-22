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
        public int TemperatureF { get; set; } // Computed column in the database off of TemperatureC / temp_c
        public string Summary { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
