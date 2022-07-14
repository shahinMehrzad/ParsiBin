using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class Position : IAggregateRoot
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
