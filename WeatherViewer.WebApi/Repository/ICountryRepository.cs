using WeatherViewer.WebApiEntities;
using WeatherViewer.WebApiWebApi.Repository;

namespace WeatherViewer.WebApi.Repository
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        Task<Country> GetByName(string name);
        Task<List<Country>> QueryByName(string name);
    }
}