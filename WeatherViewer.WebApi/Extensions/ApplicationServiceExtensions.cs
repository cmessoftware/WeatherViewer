using WeatherViewer.WebApi.Repository;
using WeatherViewer.WebApi.Services;
using WeatherViewer.WebApiWebApi.Repository;
using WeatherViewer.WebApiWebApi.Services;

namespace WeatherViewer.WebApi.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {

            ////Configure logging interface
            //services.AddLogging(logger => {
            //    logger.AddDebug();
            //    logger.AddConsole();
            //});


            services.AddScoped<ICityService, CityService>();
            services.AddScoped<ICountryService, CountryService>();


            //Configure repository interfaces
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();

          
        }   

        public static string JoinString<T>(this IEnumerable<T> source, string delimiter, Func<T, string> func)
        {
            return string.Join(delimiter, source.Select(func).ToArray());
        }
    }
}
