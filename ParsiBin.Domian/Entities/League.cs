using ParsiBin.Domain.Common.Contracts;
using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class League : AuditableEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
        private List<Season> _seasons = new List<Season>(); 
        public IEnumerable<Season> Seasons => _seasons.AsReadOnly();
    }
}
