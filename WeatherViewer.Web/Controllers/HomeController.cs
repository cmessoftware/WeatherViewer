using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeatherViewer.Web.Models;

namespace WeatherViewer.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;
        private readonly Uri _baseUrl;

        public HomeController(ILogger<HomeController> logger,
                              IConfiguration config)
        {
            _logger = logger;
            _config = config;
            _baseUrl = new Uri(_config.GetValue<string>("WebApi:BaseUrl"));
        }
        [HttpGet]
        [Route("{cities}")]
        public async Task<IActionResult> GetCities()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}