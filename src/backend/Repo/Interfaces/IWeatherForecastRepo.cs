using System;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.BusinessLogic
{
    public interface IWeatherForecastRepo
    {
        Task AddForecastAsync();
        Task<WeatherForecast> GetWeatherForecastAsync(Guid forecastId);
    }
}