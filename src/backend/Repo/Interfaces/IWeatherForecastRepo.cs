using System;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.Repo.Interfaces
{
    public interface IWeatherForecastRepo
    {
        Task AddForecastAsync(WeatherForecast weatherForecast);
        Task<WeatherForecast> GetWeatherForecastAsync(Guid forecastId);
    }
}