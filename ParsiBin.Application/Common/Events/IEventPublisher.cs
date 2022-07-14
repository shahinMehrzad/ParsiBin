using ParsiBin.Application.Common.Interfaces;
using ParsiBin.SharedKernel.Events;

namespace ParsiBin.Application.Common.Events
{
    public interface IEventPublisher : ITransientService
    {
        Task PublishAsync(IEvent @event);
    }
}
