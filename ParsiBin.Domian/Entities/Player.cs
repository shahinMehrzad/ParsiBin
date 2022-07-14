using ParsiBin.Domain.Common.Contracts;
using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class Player : AuditableEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Country Nationality { get; set; }
        public DateTime RetirementDate { get; set; }
    }
}
