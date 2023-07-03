using WeatherViewer.WebApi.Extensions;
using Microsoft.EntityFrameworkCore;
using WeatherViewer.WebApiControllers;
using WeatherViewer.WebApiData;

namespace WeatherViewer.WebApiWebApi.Repository
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ILogger _log;
        protected readonly WeatherViewerContext _context;

        protected GenericRepository(ILogger log,
                                    WeatherViewerContext context)
        {
            _context = context;
            _log = log;
        }

        public async Task<TEntity> GetById(int? id)
        {
            try
            {
                return await _context.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {
                _log.LogException(ex);

                throw;
            }
        }

        public async Task<List<TEntity>> GetAll()
        {
            try
            {
                return await _context.Set<TEntity>().ToListAsync();
            }
            catch (Exception ex)
            {
                _log.LogException(ex);
                throw;
            }
        }

        public async Task<bool> Create(TEntity entity)
        {
            try
            {
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _log.LogException(ex);

                throw;
            }
            return true;
        }


        public async Task<bool> Delete(int? id)
        {

            try
            {
                var entity = await GetById(id);
                if (entity == null) return false;

                var enEntryRemove = _context.Set<TEntity>().Remove(entity);
                if (enEntryRemove == null) return false;

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                _log.LogException(ex);

                throw;
            }
        }

        public async Task<bool> Update(TEntity entity)
        {
            try
            {
                if (entity == null) return false;
                var enEntry = _context.Set<TEntity>().Update(entity);

                if (enEntry == null) return false;
                await _context.SaveChangesAsync();

                if (enEntry.State == EntityState.Modified)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                _log.LogException(ex);

                throw;
            }

        }

    }
}

