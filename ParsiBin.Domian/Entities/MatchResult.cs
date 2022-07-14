using ParsiBin.Domain.Common.Contracts;
using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class MatchResult : AuditableEntity, IAggregateRoot
    {
        public Match Match { get; set; }
        public int HomeGoal { get; set; }
        public int AwayGoal { get; set; }
    }
}
