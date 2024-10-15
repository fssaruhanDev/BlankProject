using Microsoft.AspNetCore.Mvc;

namespace OrderService.Api.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        // hava durumlarýný getiren servis
        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get() {
            return Ok("Hava durumu bilgileri");
        }
        //Summeries bilgilerini döndüren servis
        [HttpGet("Summeries", Name = "GetSummeries")]
        public IActionResult GetSummeries()
        {
            return Ok(Summaries);
        }



    }
}
