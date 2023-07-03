using WeatherViewer.WebApiWebApi.Repository;

namespace WeatherViewer.WebApiWebApi.Services
{
    public abstract class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private readonly IGenericRepository<TEntity> _genericRepository;

        public GenericService(IGenericRepository<TEntity> genericRepository)
        {
            this._genericRepository = genericRepository;
        }


        public async Task<bool> Create(TEntity entity)
        {
            //TODO: Setera datos de auditoria.

            return await _genericRepository.Create(entity);
        }

        public async Task<bool> Delete(int? id)
        {
            //TODO: Setera datos de auditoria.
            return await _genericRepository.Delete(id);
        }


        public Task<List<TEntity>> GetAll()
        {
            //TODO: Setera datos de auditoria.
            return _genericRepository.GetAll();
        }

        public async Task<TEntity> GetById(int? id)
        {
            //TODO: Setera datos de auditoria.
            return await _genericRepository.GetById(id);
        }

        public async Task<bool> Update(TEntity entity)
        {
            //TODO: Setera datos de auditoria.
            return await _genericRepository.Update(entity);
        }

    }
}