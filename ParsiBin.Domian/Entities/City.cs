using ParsiBin.Domain.Common.Contracts;
using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class City : AuditableEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public Country Country { get; set; }
        private List<Stadium> _stadiums = new List<Stadium>();
        public IEnumerable<Stadium> Stadiums => _stadiums.AsReadOnly();
    }
}
