using Weather.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using Weather.Repo.Interfaces;

namespace Weather.Repo
{
    public class WeatherContext : DbContext, IWeatherForecastRepo
    {
        private readonly DbContextOptions<WeatherContext> _dbContext;
        public WeatherContext(DbContextOptions<WeatherContext> dbContext)
        {
            _dbContext = dbContext;
        }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        /// <summary>
        /// Add forecast to forecast table
        /// </summary>
        /// <returns></returns>
        public Task AddForecastAsync(WeatherForecast weatherForecast)
        {
            _dbContext.WeatherForecast.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieve a single weather forecast
        /// </summary>
        /// <param name="forecastId"></param>
        /// <returns></returns>
        public Task<WeatherForecast> GetWeatherForecastAsync(Guid forecastId)
        {
            throw new NotImplementedException();
        }
    }
}