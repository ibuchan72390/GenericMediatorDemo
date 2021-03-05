using GenericMediatorDemo.Application.Handlers;
using GenericMediatorDemo.Application.Queries;
using GenericMediatorDemo.Domain.Entities;
using GenericMediatorDemo.Domain.Interfaces;
using GenericMediatorDemo.Persistence.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace GenericMediatorDemo.Infrastructure
{
    public class Bootstrapper
    {
        public void InitializeServices(IServiceCollection svcCollection)
        {
            // Gotta be a better way to register these damn things...
            svcCollection.AddSingleton<IGetAll<Thing>, ThingService>();
            svcCollection.AddSingleton<IGetByKey<Thing>, ThingService>();
            svcCollection.AddSingleton<IGetByKeys<Thing>, ThingService>();

            svcCollection.AddSingleton<IGetAll<Stuff>, StuffService>();
            svcCollection.AddSingleton<IGetByKey<Stuff>, StuffService>();
            svcCollection.AddSingleton<IGetByKeys<Stuff>, StuffService>();

            svcCollection.AddSingleton<IGetAll<Person>, PersonService>();
            svcCollection.AddSingleton<IGetByKey<Person>, PersonService>();
            svcCollection.AddSingleton<IGetByKeys<Person>, PersonService>();

            // I don't think this works...they need to be expressly registered
            // https://github.com/jbogard/MediatR/issues/69
            svcCollection.AddMediatR(typeof(GetEntitiesHandler<>).Assembly);

            // More awful registration patterns...must be a better way
            svcCollection.AddSingleton<IRequestHandler<GetEntityByKeyQuery<Person>, Person>, GetEntityByKeyHandler<Person>>();
            svcCollection.AddSingleton<IRequestHandler<GetEntitiesQuery<Person>, IEnumerable<Person>>, GetEntitiesHandler<Person>>();
            svcCollection.AddSingleton<IRequestHandler<GetEntitiesByKeysQuery<Person>, IEnumerable<Person>>, GetEntitiesByKeysHandler<Person>>();

            svcCollection.AddSingleton<IRequestHandler<GetEntityByKeyQuery<Thing>, Thing>, GetEntityByKeyHandler<Thing>>();
            svcCollection.AddSingleton<IRequestHandler<GetEntitiesQuery<Thing>, IEnumerable<Thing>>, GetEntitiesHandler<Thing>>();
            svcCollection.AddSingleton<IRequestHandler<GetEntitiesByKeysQuery<Thing>, IEnumerable<Thing>>, GetEntitiesByKeysHandler<Thing>>();

            svcCollection.AddSingleton<IRequestHandler<GetEntityByKeyQuery<Stuff>, Stuff>, GetEntityByKeyHandler<Stuff>>();
            svcCollection.AddSingleton<IRequestHandler<GetEntitiesQuery<Stuff>, IEnumerable<Stuff>>, GetEntitiesHandler<Stuff>>();
            svcCollection.AddSingleton<IRequestHandler<GetEntitiesByKeysQuery<Stuff>, IEnumerable<Stuff>>, GetEntitiesByKeysHandler<Stuff>>();


            // This would be sick...
            //svcCollection.AddSingleton<IService<Person>, PersonService>();
            //svcCollection.AddSingleton<IService<Thing>, ThingService>();
            //svcCollection.AddSingleton<IService<Stuff>, StuffService>();
            //svcCollection.AddSingleton(typeof(IGetAll<>), typeof(IService<>));
            //svcCollection.AddSingleton(typeof(IGetByKey<>), typeof(IService<>));
            //svcCollection.AddSingleton(typeof(IGetByKeys<>), typeof(IService<>));
        }
    }
}
