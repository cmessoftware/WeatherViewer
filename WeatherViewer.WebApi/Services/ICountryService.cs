using WeatherViewer.WebApiEntities;
using WeatherViewer.WebApiWebApi.Services;

namespace WeatherViewer.WebApi.Services
{
    public interface ICountryService : IGenericService<Country>
    {
        Task<Country> GetByName(string name);
        Task<List<Country>> QueryByName(string name);
    }
}