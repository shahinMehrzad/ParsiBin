using ParsiBin.Domain.Entities.Base;
using ParsiBin.Domian.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParsiBin.Domain.Common.Contracts
{
    public abstract class BaseEntity : BaseEntity<int>
    {
    }

    public abstract class BaseEntity<Int> : IEntity<int>
    {
        public int Id { get; protected set; } = default!;

        [NotMapped]
        public List<DomainEvent> DomainEvents { get; } = new();

    }
}
