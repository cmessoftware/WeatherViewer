using Microsoft.AspNetCore.Mvc;

namespace WeatherViewer.Web.Helpers
{
    public class RestClientHelper<R> : IRestClientHelper
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<Helpers.RestClientHelper<R>> _logger;

        public RestClientHelper(IConfiguration configuration,
                                ILogger<RestClientHelper<R>> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        // GET: 
        public async R SentGetAsync(string resource)
        {
            IEnumerable<R> response = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:64189/api/");
                //HTTP GET
                response = await client.GetAsync(resource);
                
                if (response..IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<R>>();
                    readTask.Wait();

                    response = readTask.Result;
                }
                else //web api sent error response 
                {
          
                    _logger.LogError("Server error. Please contact administrator.");
                }
            }
            return response;
        }
    }
}
