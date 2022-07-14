using ParsiBin.Domain.Common.Contracts;
using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class Coach : AuditableEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public Country Nationality { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
