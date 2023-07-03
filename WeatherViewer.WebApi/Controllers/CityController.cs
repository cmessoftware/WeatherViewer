using Microsoft.AspNetCore.Mvc;
using System.Net;
using WeatherViewer.WebApiWebApi.Services;

namespace WeatherViewer.WebApiControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : ControllerBase
    {
    
        private readonly ILogger<CityController> _logger;
        private readonly ICityService _cityService;

        public CityController(ILogger<CityController> logger,
                              ICityService cityService)
        {
            _logger = logger;
            _cityService = cityService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            if (!ModelState.IsValid)
            {
                throw new ArgumentException($"Id invalido, StatusCode: {HttpStatusCode.BadRequest}");
            }
            else
            {
                var city = await _cityService.GetAll();

                if (city == null)
                {
                    return BadRequest();
                }
                else
                    return Ok(city);
            }

        }

        [HttpGet]
        [Route("{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            if (!ModelState.IsValid)
            {
                throw new ArgumentException($"Id invalido, StatusCode: {HttpStatusCode.BadRequest}");
            }
            else 
            {
                var city =  await _cityService.GetByName(name);

                if (city == null)
                {
                    return NotFound($"The city {name} not exist");
                }
                else
                    return Ok(city);
            }
                 
        }


        [HttpGet]
        [Route("[action]/{countryId}/{queryCity}")]
        public async Task<IActionResult> Country(int countryId, string queryCity)
        {
            if (!ModelState.IsValid)
            {
                throw new ArgumentException($"Id invalido, StatusCode: {HttpStatusCode.BadRequest}");
            }
            else
            {
                var city = await _cityService.GetByCountry(countryId, queryCity);

                if (city == null)
                {
                    return NotFound($"The country id {countryId} not exist");
                }
                else
                    return Ok(city);
            }

        }



        [HttpGet]
        [Route("[action]/{name}")]
        public async Task<IActionResult> Query(string name)
        {
            if (!ModelState.IsValid)
            {
                throw new ArgumentException($"Id invalido, StatusCode: {HttpStatusCode.BadRequest}");
            }
            else
            {
                var city = await _cityService.QueryByName(name);

                if (city == null || !city.Any())
                {
                    return NotFound($"The search country {name} not response any result");
                }
                else
                    return Ok(city);
            }

        }


    }
}