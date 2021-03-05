using MediatR;
using System.Collections.Generic;

namespace GenericMediatorDemo.Application.Queries
{
    public class GetEntitiesByKeysQuery<TEntity> : IRequest<IEnumerable<TEntity>>
    {
        public IEnumerable<string> Keys { get; set; }
    }
}
