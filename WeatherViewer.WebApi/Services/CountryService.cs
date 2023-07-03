using WeatherViewer.WebApi.Repository;
using WeatherViewer.WebApiEntities;

namespace WeatherViewer.WebApi.Services
{


    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }


        public async Task<List<Country>> GetAll()
        {
            return await _countryRepository.GetAll();
        }

        public async Task<Country> GetById(int? id)
        {
           return await _countryRepository.GetById(id); 
        }

        public async Task<Country> GetByName(string name)
        {
            return await _countryRepository.GetByName(name);
        }

        public async Task<List<Country>> QueryByName(string name)
        {
            return await _countryRepository.QueryByName(name);  
        }

        public Task<bool> Update(Country entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Create(Country entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int? id)
        {
            throw new NotImplementedException();
        }
    }
}