using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class TeamPlayers : IAggregateRoot
    {
        public int Id { get; set; }
        public Team Team { get; set; }
        public Player Player { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime LeftDate { get; set; }
        public int ShirtNumber { get; set; }
        public bool Status { get; set; }
    }
}
