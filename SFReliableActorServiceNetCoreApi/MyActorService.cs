using System;
using System.Fabric;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Client;
using Microsoft.ServiceFabric.Actors.Runtime;

namespace SFReliableActorServiceNetCoreApi
{
    public class MyActorService : ActorService
    {
        public MyActorService(
            StatefulServiceContext context, 
            ActorTypeInformation actorTypeInfo, 
            Func<ActorService, ActorId, ActorBase> actorFactory = null, 
            Func<ActorBase, IActorStateProvider, IActorStateManager> stateManagerFactory = null, 
            IActorStateProvider stateProvider = null, 
            ActorServiceSettings settings = null)
            : base(context, actorTypeInfo, actorFactory, stateManagerFactory, stateProvider, settings)
        {
        }

        protected async override Task RunAsync(CancellationToken cancellationToken)
        {
            await base.RunAsync(cancellationToken);

            var proxy = ActorProxy.Create<IMyActor>(new ActorId(0));

            await proxy.StartWork();
        }
    }
}
