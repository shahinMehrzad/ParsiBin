

using ParsiBin.Domain.Common.Contracts;

namespace ParsiBin.Domain.Entities.Base
{
    public interface IBaseEntity
    {
        List<DomainEvent> DomainEvents { get; }
    }

    public interface IEntity<Int> : IBaseEntity
    {
        int Id { get; }
    }
}
