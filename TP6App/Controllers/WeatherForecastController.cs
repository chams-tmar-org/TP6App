using Microsoft.AspNetCore.Mvc;
using TP6App.Models;
using TP6App.Services;

namespace TP6App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IweatherForecastService _weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult Add([FromBody] WeatherForecast weatherForecast)
        {
            _weatherForecastService.AddWeatherForecast(weatherForecast);
            return Ok();
        }





    }
}