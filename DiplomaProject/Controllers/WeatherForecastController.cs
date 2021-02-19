using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DiplomaProject.Controllers
{
    /// <summary>
    /// Weather Controller respponsible for GET/POST for managing weather 
    /// </summary>
    [ApiController]
    //[Route("[controller]")]       // oryginalny route
    [Route("api/weatherforecast")]  // tak też działa, ale poprawnie jest z controller, jak poniżej
    [Route("api/[controller]")]     // konwencja, że weatherforecast odpali się po ścieżce api

    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        // ten opis poniżej pojawi się w Swaggerze xD
        /// <summary>
        /// This GET method returns fake weather 
        /// </summary>
        /// <returns>An array of weather forecast</returns>
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("employee")]
        public string GetEmployee()
        {
            return "Edek";
        }
    }
}
