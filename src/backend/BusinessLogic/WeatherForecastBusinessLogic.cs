using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Weather.BusinessLogic.Interfaces;
using Weather.Models;
using Weather.Repo.Interfaces;

namespace Weather.BusinessLogic
{
    public class WeatherForecastBusinessLogic : IWeatherForecastBusinessLogic
    {
        public WeatherForecastBusinessLogic(ILogger logger, IWeatherForecastRepo weatherForecastRepo)
        {
            _logger = logger;
            _weatherForecastRepo = weatherForecastRepo;
        }

        private readonly ILogger _logger;
        private readonly IWeatherForecastRepo _weatherForecastRepo; 

        /// <summary>
        /// Add a forecast
        /// </summary>
        /// <param name="weatherForecast"></param>
        /// <returns></returns>
        public async Task AddForecastAsync(WeatherForecast weatherForecast)
        {
            _logger.LogInformation($"Adding forecast with Guid: {weatherForecast.ForecastId}");
            await _weatherForecastRepo.AddForecastAsync();
        }

        /// <summary>
        /// Get a single forecast.
        /// Figure out how to use Guid[] for IEnumerable forecasts
        /// </summary>
        /// <param name="forecastId"></param>
        /// <returns></returns>
        public async Task<WeatherForecast> GetWeatherForecastAsync(Guid forecastId)
        {
            _logger.LogInformation($"Retrieving forecast from Guid: {forecastId}");
            return await _weatherForecastRepo.GetWeatherForecastAsync(forecastId);
        }
    }
}