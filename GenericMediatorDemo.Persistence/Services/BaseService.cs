using GenericMediatorDemo.Domain.Entities;
using GenericMediatorDemo.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GenericMediatorDemo.Persistence.Services
{
    public abstract class BaseService<TEntity> : IService<TEntity>
    {
        protected abstract string GetKey(TEntity entity);

        public TEntity GetByKey(string key)
        {
            return Entities.FirstOrDefault(x => GetKey(x) == key);
        }

        public IEnumerable<TEntity> GetByKeys(IEnumerable<string> keys)
        {
            return Entities.Where(x => keys.Contains(GetKey(x)));
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Entities;
        }

        protected IEnumerable<TEntity> Entities
        {
            get {
                if (typeof(TEntity) == typeof(Person))
                {
                    return (IEnumerable<TEntity>) Db.Persons;
                }
                else if (typeof(TEntity) == typeof(Stuff))
                {
                    return Db.Stuffs as IEnumerable<TEntity>;
                }
                else if (typeof(TEntity) == typeof(Thing))
                {
                    return Db.Things as IEnumerable<TEntity>;
                }
                else
                {
                    throw new System.Exception("Invalid Service Type Received");
                }
            }
        }
    }
}
