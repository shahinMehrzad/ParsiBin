using ParsiBin.Domain.Entities.Base;
using ParsiBin.Domian.Entities.Base;

namespace ParsiBin.Domain.Common.Events
{
    public static class EntityUpdatedEvent
    {
        public static EntityUpdatedEvent<TEntity> WithEntity<TEntity>(TEntity entity)
            where TEntity : IBaseEntity
            => new(entity);
    }

    public class EntityUpdatedEvent<TEntity> : DomainEventBase
        where TEntity : IBaseEntity
    {
        internal EntityUpdatedEvent(TEntity entity) => Entity = entity;

        public TEntity Entity { get; }
    }
}
