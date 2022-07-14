using MediatR;

namespace ParsiBin.Domian.Entities.Base
{
    public abstract class DomainEventBase : INotification
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}
