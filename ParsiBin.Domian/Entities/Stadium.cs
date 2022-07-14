using ParsiBin.Domain.Common.Contracts;
using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class Stadium : AuditableEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public City City { get; set; }
        //public virtual List<Team> TeamsArena { get; set; }
    }
}
