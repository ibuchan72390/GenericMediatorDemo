using GenericMediatorDemo.Domain.Entities;
using MediatR;

namespace GenericMediatorDemo.Api.Controllers
{
    public class StuffController : BaseController<Stuff>
    {
        public StuffController(IMediator mediator) : base(mediator)
        {
        }
    }
}
