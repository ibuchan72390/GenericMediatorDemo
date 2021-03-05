using GenericMediatorDemo.Domain.Entities;

namespace GenericMediatorDemo.Persistence.Services
{
    public class PersonService : BaseService<Person>
    {
        protected override string GetKey(Person entity)
        {
            return entity.PersonKey;
        }
    }
}
