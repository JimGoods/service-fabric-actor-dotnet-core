using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace SFReliableActorService.Interfaces
{
    public interface IMyActor : IActor
    {
        Task StartWork();
    }
}
