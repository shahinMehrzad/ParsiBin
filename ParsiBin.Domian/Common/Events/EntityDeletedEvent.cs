using ParsiBin.Domain.Entities.Base;
using ParsiBin.Domian.Entities.Base;

namespace ParsiBin.Domain.Common.Events
{
    public static class EntityDeletedEvent
    {
        public static EntityDeletedEvent<TEntity> WithEntity<TEntity>(TEntity entity)
            where TEntity : IBaseEntity
            => new(entity);
    }

    public class EntityDeletedEvent<TEntity> : DomainEventBase
        where TEntity : IBaseEntity
    {
        internal EntityDeletedEvent(TEntity entity) => Entity = entity;

        public TEntity Entity { get; }
    }
}
