using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class TeamCoach : IAggregateRoot
    {
        public int Id { get; set; }
        public Team Team { get; set; }
        public Coach Coach { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime LeftDate { get; set; }
        public bool Status { get; set; }
    }
}
