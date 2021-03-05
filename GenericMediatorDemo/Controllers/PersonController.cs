using GenericMediatorDemo.Domain.Entities;
using MediatR;

namespace GenericMediatorDemo.Api.Controllers
{
    public class PersonController : BaseController<Person>
    {
        public PersonController(IMediator mediator) : base(mediator)
        {
        }
    }
}
