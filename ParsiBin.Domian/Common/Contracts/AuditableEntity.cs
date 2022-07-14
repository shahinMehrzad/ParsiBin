using ParsiBin.Domain.Entities.Base;

namespace ParsiBin.Domain.Common.Contracts
{
    public abstract class AuditableEntity : AuditableEntity<int>
    {
    }

    public abstract class AuditableEntity<T> : BaseEntity<T>, IAuditableBaseEntity, ISoftDelete
    {
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; private set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public Guid? DeletedBy { get; set; }     

        protected AuditableEntity()
        {
            CreatedOn = DateTime.UtcNow;
            LastModifiedOn = DateTime.UtcNow;
        }
    }
}
