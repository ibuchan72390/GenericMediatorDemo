using MediatR;
using System.Collections.Generic;

namespace GenericMediatorDemo.Application.Queries
{
    public class GetEntitiesQuery<T> : IRequest<IEnumerable<T>>
    {
    }
}
