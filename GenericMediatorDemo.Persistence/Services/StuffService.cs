using GenericMediatorDemo.Domain.Entities;

namespace GenericMediatorDemo.Persistence.Services
{
    public class StuffService : BaseService<Stuff>
    {
        protected override string GetKey(Stuff entity)
        {
            return entity.StuffKey;
        }
    }
}
