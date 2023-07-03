using Microsoft.EntityFrameworkCore;
using WeatherViewer.WebApiData;
using WeatherViewer.WebApiEntities;
using WeatherViewer.WebApiWebApi.Repository;

namespace WeatherViewer.WebApi.Repository
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        private readonly ILogger<CountryRepository> _logger;
        private readonly WeatherViewerContext _context;

        public CountryRepository(ILogger<CountryRepository> logger,
                                 WeatherViewerContext context)
            : base(logger, context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<List<Country>> GetAll()
        {
            return await base.GetAll();
        }

        public async Task<Country> GetById(int? id)
        {
            return await base.GetById(id);
        }

        public async Task<Country> GetByName(string name)
        {
            return await _context.Country.FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task<List<Country>> QueryByName(string name)
        {
            return await _context.Country.Where(x => x.Name.Contains(name)).ToListAsync();
        }

        public Task<bool> Update(Country entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Create(Country entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int? id)
        {
            throw new NotImplementedException();
        }
    }
}