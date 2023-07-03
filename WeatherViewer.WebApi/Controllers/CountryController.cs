using Microsoft.AspNetCore.Mvc;
using System.Net;
using WeatherViewer.WebApi.Services;

namespace WeatherViewer.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {

        private readonly ILogger<CountryController> _logger;
        private readonly ICountryService _countryService;

        public CountryController(ILogger<CountryController> logger,
                                 ICountryService countryService)
        {
            _logger = logger;
            _countryService = countryService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByName(string name)
        {
            if (!ModelState.IsValid)
            {
                throw new ArgumentException($"Id invalido, StatusCode: {HttpStatusCode.BadRequest}");
            }
            else
            {
                var country = await _countryService.GetByName(name);

                if (country == null)
                {
                    return NotFound($"The city {name} not exist");
                }
                else
                    return Ok(country);
            }

        }


        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> QueryCities(string name)
        {
            if (!ModelState.IsValid)
            {
                throw new ArgumentException($"Id invalido, StatusCode: {HttpStatusCode.BadRequest}");
            }
            else
            {
                var country = await _countryService.QueryByName(name);

                if (country == null)
                {
                    return NotFound($"The city {name} not exist");
                }
                else
                    return Ok(country);
            }

        }


    }
}