using System.Collections.Generic;

namespace GenericMediatorDemo.Domain.Interfaces
{
    public interface IService<TEntity> : IGetByKey<TEntity>, IGetByKeys<TEntity>, IGetAll<TEntity>
    {
    }

    public interface IGetAll<TEntity>
    {
        public IEnumerable<TEntity> GetAll();
    }

    public interface IGetByKey<TEntity>
    {
        public TEntity GetByKey(string key);
    }

    public interface IGetByKeys<TEntity>
    {
        public IEnumerable<TEntity> GetByKeys(IEnumerable<string> keys);
    }
}
