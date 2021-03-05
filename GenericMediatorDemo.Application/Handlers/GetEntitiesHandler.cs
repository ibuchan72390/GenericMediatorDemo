using GenericMediatorDemo.Application.Queries;
using GenericMediatorDemo.Domain.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GenericMediatorDemo.Application.Handlers
{
    public class GetEntitiesHandler<TEntity> : IRequestHandler<GetEntitiesQuery<TEntity>, IEnumerable<TEntity>>
    {
        public IGetAll<TEntity> _svc;

        public GetEntitiesHandler(IGetAll<TEntity> svc)
        {
            _svc = svc;
        }

        public Task<IEnumerable<TEntity>> Handle(GetEntitiesQuery<TEntity> request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_svc.GetAll());
        }
    }
}
