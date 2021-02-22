using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Weather.Models;
using Weather.BusinessLogic.Interfaces;

namespace Weather.Controllers
{
    [ApiController]
    [Route("weatherforecast")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController(ILogger<WeatherForecastController> logger,
                                         IWeatherForecastBusinessLogic weatherForecastBusinessLogic)
        {
            _logger = logger;
            _weatherforecastbusinesslogic = weatherForecastBusinessLogic;
        }

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastBusinessLogic _weatherforecastbusinesslogic;

        [HttpGet]
        public async Task<IActionResult> GetWeatherForecastAsync([FromForm] Guid forecastId)
        {
            await _weatherforecastbusinesslogic.GetWeatherForecastAsync(forecastId);
            return Ok();
        }

        public async Task<IActionResult> AddForecastAsync([FromBody] WeatherForecast weatherForecast)
        {
            await _weatherforecastbusinesslogic.AddForecastAsync(weatherForecast);
            return Ok();
        }
    }
}
