namespace ParsiBin.Domain.Entities.Base
{
    public interface IAuditableBaseEntity 
    {
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; }
        public Guid LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
