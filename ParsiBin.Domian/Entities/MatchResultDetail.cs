using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class MatchResultDetail : IAggregateRoot
    {
        public int Id { get; set; }
        public MatchResult MatchResult { get; set; }
        public int Minute { get; set; }
        public Player Player { get; set; }
        public Team Team { get; set; }
        public ActionType ActionType { get; set; }
    }
}
