using WeatherViewer.WebApiEntities;

namespace WeatherViewer.WebApiWebApi.Services
{
    public interface ICityService : IGenericService<City>
    {
        Task <List<City>> GetByCountry(int countryId, string queryCity);
        Task<City> GetByName(string name);
        Task<List<City>>QueryByName(string name);
    }
}
