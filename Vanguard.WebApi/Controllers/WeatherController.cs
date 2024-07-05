using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Vanguard.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
        public class WeatherController : ControllerBase
        {
            private readonly WeatherService _weatherService;

            public WeatherController(WeatherService weatherService)
            {
                _weatherService = weatherService;
            }

            [HttpGet("{city}")]
            public async Task<IActionResult> GetWeather(string city)
            {
                try
                {
                    var weatherData = await _weatherService.GetWeatherAsync(city);
                    return Ok(weatherData);
                }
                catch (Exception ex)
                {
                    return StatusCode(500, new { message = ex.Message });
                }
            }
        }
    }




