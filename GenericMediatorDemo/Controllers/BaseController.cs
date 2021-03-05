using GenericMediatorDemo.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericMediatorDemo.Api.Controllers
{
    [Route("{controller}")]
    public abstract class BaseController<TEntity>
    {
        private readonly IMediator _mediator;

        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{key}")]
        public Task<TEntity> GetByKey(string key)
        {
            return _mediator.Send(new GetEntityByKeyQuery<TEntity> { Key = key });
        }

        [HttpGet]
        public async Task<IEnumerable<TEntity>> Get([FromQuery]IEnumerable<string> keys)
        {
            if (keys.Any())
            {
                var result = await _mediator.Send(new GetEntitiesByKeysQuery<TEntity> { Keys = keys });

                return result;
            }
            else
            {
                var result = await _mediator.Send(new GetEntitiesQuery<TEntity>());

                return result;
            }
        }
    }
}
