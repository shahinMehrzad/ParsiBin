using ParsiBin.Domain.Common.Contracts;
using ParsiBin.SharedKernel.Interfaces;

namespace ParsiBin.Domain.Entities
{
    public class ActionType : AuditableEntity, IAggregateRoot
    {
        public string Name { get; set; }
    }
}
