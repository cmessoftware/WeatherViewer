using WeatherViewer.WebApiEntities;
using WeatherViewer.WebApiWebApi.Repository;

namespace WeatherViewer.WebApiWebApi.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public Task<bool> Create(City entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<City>> GetAll()
        {
            return await _cityRepository.GetAll();
        }

        public async Task<List<City>> GetByCountry(int countryId, string queryCity)
        {
            return await _cityRepository.GetByCountry(countryId, queryCity);
        }

        public Task<City> GetById(int? id)
        {
            return _cityRepository.GetById(id);
        }

        public async Task<City> GetByName(string name)
        {
            return await _cityRepository.GetByName(name);
        }

        public async Task<List<City>> QueryByName(string name)
        {
            return await _cityRepository.QueryByName(name);
        }

        public Task<bool> Update(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
