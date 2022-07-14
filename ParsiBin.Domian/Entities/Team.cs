using ParsiBin.Domain.Common.Contracts;
using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class Team : AuditableEntity, IAggregateRoot
    {        
        public string Name { get; set; }
        public string Logo { get; set; }
        //public Country Country { get; set; }
        //public City City { get; set; }
        //public Stadium Stadium { get; set; }
        public string Description { get; set; }
        private List<SeasonTeams> _seasonTeams  = new List<SeasonTeams>();
        public IEnumerable<SeasonTeams> SeasonTeams => _seasonTeams.AsReadOnly();
        private List<TeamPlayers> _teamPlayers = new List<TeamPlayers>();
        public IEnumerable<TeamPlayers> TeamPlayers =>  _teamPlayers.AsReadOnly();
        //public virtual Coach Coach { get; set; }
    }
}
