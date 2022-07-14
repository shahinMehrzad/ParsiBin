using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class SeasonTeams : IAggregateRoot
    {
        public int Id { get; set; }
        public Season Season { get; set; }
        public Team Team { get; set; }
    }
}
