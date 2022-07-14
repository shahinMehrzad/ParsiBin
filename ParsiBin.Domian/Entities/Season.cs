using ParsiBin.Domain.Common.Contracts;
using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class Season : AuditableEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public League League { get; set; }
        private List<SeasonTeams> _seasonTeams = new List<SeasonTeams>();
        public IEnumerable<SeasonTeams> SeasonTeams => _seasonTeams.AsReadOnly();
    }
}
