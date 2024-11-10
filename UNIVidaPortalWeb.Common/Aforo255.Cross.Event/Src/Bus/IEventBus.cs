using Aforo255.Cross.Event.Src.Commands;
using System.Threading.Tasks;

namespace Aforo255.Cross.Event.Src.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Aforo255.Cross.Event.Src.Events.Event;

        void Subscribe<T, TH>()
            where T : Aforo255.Cross.Event.Src.Events.Event
            where TH : IEventHandler<T>;
    }
}
