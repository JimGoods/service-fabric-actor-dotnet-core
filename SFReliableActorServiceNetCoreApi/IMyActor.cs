using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace SFReliableActorServiceNetCoreApi
{
    public interface IMyActor : IActor
    {
        Task StartWork();
    }
}
