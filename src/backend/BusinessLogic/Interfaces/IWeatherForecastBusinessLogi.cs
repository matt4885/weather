using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.BusinessLogic.Interfaces
{
    public interface IWeatherForecastBusinessLogic
    {
        Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync(Guid forecastId);
    }
}