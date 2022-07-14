using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class PlayerPosition : IAggregateRoot
    {
        public int Id { get; set; }
        public Player Player { get; set; }
        public Position Position { get; set; }
    }
}
