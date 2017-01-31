using System;
using System.Threading;
using Microsoft.ServiceFabric.Actors.Runtime;

namespace SFReliableActorService
{
    internal static class Program
    {
        /// <summary>
        /// This is the entry point of the service host process.
        /// </summary>
        private static void Main()
        {
            try
            {
                ActorRuntime.RegisterActorAsync<MyActor>((context, actorType) => new MyActorService(context, actorType)).GetAwaiter().GetResult();

                Thread.Sleep(Timeout.Infinite);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
