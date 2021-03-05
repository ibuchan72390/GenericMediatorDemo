using GenericMediatorDemo.Domain.Entities;

namespace GenericMediatorDemo.Persistence.Services
{
    public class ThingService : BaseService<Thing>
    {
        protected override string GetKey(Thing entity)
        {
            return entity.ThingKey;
        }
    }
}
