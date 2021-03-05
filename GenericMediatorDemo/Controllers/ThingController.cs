using GenericMediatorDemo.Domain.Entities;
using MediatR;

namespace GenericMediatorDemo.Api.Controllers
{
    public class ThingController : BaseController<Thing>
    {
        public ThingController(IMediator mediator) : base(mediator)
        {
        }
    }
}
