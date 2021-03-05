using GenericMediatorDemo.Application.Queries;
using GenericMediatorDemo.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GenericMediatorDemo.Application.Handlers
{
    public class GetEntityByKeyHandler<TEntity> : IRequestHandler<GetEntityByKeyQuery<TEntity>, TEntity>
    {
        private readonly IGetByKey<TEntity> _svc;

        public GetEntityByKeyHandler(
            IGetByKey<TEntity> svc)
        {
            _svc = svc;
        }

        public Task<TEntity> Handle(GetEntityByKeyQuery<TEntity> request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_svc.GetByKey(request.Key));
        }
    }
}
