using ParsiBin.Domain.Common.Contracts;
using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class Country : AuditableEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Flag { get; set; }
        private List<City> _cities = new List<City>();
        public  IEnumerable<City> Cities => _cities.AsReadOnly();
    }
}
