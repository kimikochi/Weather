using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using XtramileTest.API.Service;
using XtramileTest.Core.Models;

namespace XtramileTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("{id}")]
        public Weather Get(string id)
        {
            var result = _weatherService.GetCityWeather(id);
            return result;
        }

        [HttpGet("converter/{tempF}")]
        public double Get(double tempF)
        {
            var result = _weatherService.ConvertFToC(tempF);
            return result;
        }
    }
}
