using System;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.BusinessLogic.Interfaces
{
    public interface IWeatherForecastBusinessLogic
    {
        Task<WeatherForecast> GetWeatherForecastAsync(Guid forecastId);
        Task AddForecastAsync(WeatherForecast weatherForecast);
    }
}