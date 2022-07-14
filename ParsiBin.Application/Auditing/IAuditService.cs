using ParsiBin.Application.Common.Interfaces;

namespace ParsiBin.Application.Auditing
{
    public interface IAuditService : ITransientService
    {
        Task<List<AuditDto>> GetUserTrailsAsync(Guid userId);
    }
}
