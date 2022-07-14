using ParsiBin.Domain.Common.Contracts;

namespace ParsiBin.Domain.Entities
{
    public class Audit : AuditableEntity
    {
        public string UserId { get; set; }
        public string Type { get; set; }
        public string TableName { get; set; }
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
        public string Values { get; set; }
        public string PrimaryKey { get; set; }
    }
}
