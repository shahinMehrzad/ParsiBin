using ParsiBin.SharedKernel.Events;

namespace ParsiBin.Application.Common.Events
{
    public interface IEventNotificationHandler<TEvent> : INotificationHandler<EventNotification<TEvent>>
    where TEvent : IEvent
    {
    }
}
