using Ardalis.Specification;
using ParsiBin.Domain.Common.Contracts;

namespace ParsiBin.Application.Common.Specification
{
    public class AuditableEntitiesByCreatedOnBetweenSpec<T> : Specification<T>
    where T : AuditableEntity
    {
        public AuditableEntitiesByCreatedOnBetweenSpec(DateTime from, DateTime until) =>
            Query.Where(e => e.CreatedOn >= from && e.CreatedOn <= until);
    }
}
