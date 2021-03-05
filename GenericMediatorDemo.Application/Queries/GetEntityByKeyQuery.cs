using MediatR;

namespace GenericMediatorDemo.Application.Queries
{
    public class GetEntityByKeyQuery<TEntity> : IRequest<TEntity>
    {
        public string Key { get; set; }
    }
}
