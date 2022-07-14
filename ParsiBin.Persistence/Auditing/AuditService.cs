using ParsiBin.Application.Auditing;
using ParsiBin.Persistence.Context;

namespace ParsiBin.Persistence.Auditing
{
    public class AuditService : IAuditService
    {
        private readonly ParsibinContext _context;

        public AuditService(ParsibinContext context) => _context = context;

        public async Task<List<AuditDto>> GetUserTrailsAsync(Guid userId)
        {
            var trails = await _context.AuditTrails
                .Where(a => a.UserId == userId)
                .OrderByDescending(a => a.DateTime)
                .Take(250)
                .ToListAsync();

            return trails.Adapt<List<AuditDto>>();
        }
    }
}
