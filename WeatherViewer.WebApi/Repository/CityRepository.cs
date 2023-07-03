using Microsoft.EntityFrameworkCore;
using System.Linq;
using WeatherViewer.WebApiData;
using WeatherViewer.WebApiEntities;

namespace WeatherViewer.WebApiWebApi.Repository
{
    public class CityRepository : GenericRepository<City>,  ICityRepository
    {
        private readonly ILogger<CityRepository> _log;
        private readonly WeatherViewerContext _context;

        public CityRepository(ILogger<CityRepository> log , 
                              WeatherViewerContext context) 
            : base(log, context)
        {
            _log = log;
            _context = context;
        }
       

        public new async Task<List<City>> GetAll()
        {
            return await base.GetAll();
        }

        public async Task<City> GetById(int? id)
        {
            return await base.GetById(id);  
        }


        public async Task<List<City>> GetByCountry(int countryId, string queryCity)
        {
            var country = await _context.Country.Include(x => x.Cities)
                         .Where(x => x.Id == countryId)
                         .ToListAsync();

            var cities = country.SelectMany(c => c.Cities)
                        .Where(city => city.Name.Contains(queryCity))
                        .ToList();


            return cities;
        }


        public async Task<City> GetByName(string name)
        {
            return await _context.City.
                         FirstOrDefaultAsync(x => x.Name.Trim().ToUpper() == name.Trim().ToUpper());
        }

        public async Task<List<City>> QueryByName(string name)
        {
            //Pais por defecto : Argentina
            var defaultCountry = "Argentina";

            return await _context.City.Where(x => x.Name.Contains(name)).ToListAsync();
        }

        public new async Task<bool> Update(City entity)
        {
            return await base.Update(entity);
        }

        public new async Task<bool> Create(City entity)
        {
            return await base.Create(entity);
        }

        public new async Task<bool> Delete(int? id)
        {
            return await base.Delete(id);
        }

    }
}
