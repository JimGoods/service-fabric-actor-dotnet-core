using System;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Runtime;

namespace SFReliableActorServiceNetCoreApi
{
    public class MyActor : Actor, IRemindable, IMyActor
    {
        public MyActor(ActorService actorService, ActorId actorId) : base(actorService, actorId)
        {
        }

        protected override async Task OnActivateAsync()
        {
            await base.OnActivateAsync();
            IActorReminder reminderRegistration = await RegisterReminderAsync("Reminder", BitConverter.GetBytes(100), TimeSpan.FromSeconds(0), TimeSpan.FromSeconds(10));
            return;
        }

        public Task ReceiveReminderAsync(string reminderName, byte[] context, TimeSpan dueTime, TimeSpan period)
        {
            string test = reminderName;
            return Task.FromResult(true);
        }

        public Task StartWork()
        {
            return Task.FromResult(true);
        }
    }
}
