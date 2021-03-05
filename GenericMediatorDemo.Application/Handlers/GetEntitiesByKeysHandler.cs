using GenericMediatorDemo.Application.Queries;
using GenericMediatorDemo.Domain.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GenericMediatorDemo.Application.Handlers
{
    public class GetEntitiesByKeysHandler<TEntity> : IRequestHandler<GetEntitiesByKeysQuery<TEntity>, IEnumerable<TEntity>>
    {
        private readonly IGetByKeys<TEntity> _svc;

        public GetEntitiesByKeysHandler(IGetByKeys<TEntity> svc)
        {
            _svc = svc;
        }

        public Task<IEnumerable<TEntity>> Handle(GetEntitiesByKeysQuery<TEntity> request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_svc.GetByKeys(request.Keys));
        }
    }
}
