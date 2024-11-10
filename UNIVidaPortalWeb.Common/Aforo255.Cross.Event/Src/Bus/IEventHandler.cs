using Aforo255.Cross.Event.Src.Events;
using System.Threading.Tasks;

namespace Aforo255.Cross.Event.Src.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
         where TEvent : Aforo255.Cross.Event.Src.Events.Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}
