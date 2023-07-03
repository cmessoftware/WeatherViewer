using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WeatherViewer.WebApiDto;

namespace WeatherViewer.WebApiControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
    
        private readonly ILogger<WeatherController> _logger;

        public WeatherController(ILogger<WeatherController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();        
        }


        [HttpGet]
        public async Task<IActionResult> Current(WeatherDataDto data)
        {

            List<WeatherDataDto> response = new List<WeatherDataDto>();

            return Ok(response);
        }
    }
}