using Microsoft.AspNetCore.Mvc;

namespace RestaurantApi1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _service;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("generate")]
        public ActionResult<IEnumerable<WeatherForecast>> Generate([FromQuery] int take, [FromBody] Temperature temp)
        {
            if ( take < 0 || temp.Max < temp.Min)
            {
                return BadRequest();
            }

            var result = _service.Get(take, temp.Max, temp.Min);
            return Ok(result);
        }
    }
}