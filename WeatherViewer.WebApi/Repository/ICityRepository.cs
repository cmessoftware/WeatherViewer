using WeatherViewer.WebApiEntities;

namespace WeatherViewer.WebApiWebApi.Repository
{
    public interface ICityRepository : IGenericRepository<City>
    {
        Task<List<City>> GetByCountry(int cuntryId,string queryCity);
        Task<City> GetByName(string name);
        Task<List<City>> QueryByName(string name);
    }
}
