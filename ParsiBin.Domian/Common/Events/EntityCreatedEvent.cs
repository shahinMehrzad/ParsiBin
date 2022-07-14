using ParsiBin.Domain.Entities.Base;
using ParsiBin.Domian.Entities.Base;

namespace ParsiBin.Domain.Common.Events
{
    public static class EntityCreatedEvent
    {
        public static EntityCreatedEvent<TEntity> WithEntity<TEntity>(TEntity entity)
            where TEntity : IBaseEntity
            => new(entity);
    }

    public class EntityCreatedEvent<TEntity> : DomainEventBase
        where TEntity : IBaseEntity
    {
        internal EntityCreatedEvent(TEntity entity) => Entity = entity;

        public TEntity Entity { get; }
    }
}
