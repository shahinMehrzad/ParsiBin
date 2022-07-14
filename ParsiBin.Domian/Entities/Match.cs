using ParsiBin.Domain.Common.Contracts;
using ParsiBin.Domian.Enums;
using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class Match : AuditableEntity, IAggregateRoot
    {
        public League League { get; set; }
        public Season Season { get; set; }
        public Stadium Stadium { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public int Week { get; set; }
        public DateTime MatchDate { get; set; }        
        public MatchStatus MatchStatus { get; set; }
    }
}
