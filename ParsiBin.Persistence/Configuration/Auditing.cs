using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParsiBin.Persistence.Auditing;

namespace ParsiBin.Persistence.Configuration
{
    public class AuditTrailConfig : IEntityTypeConfiguration<Trail>
    {
        public void Configure(EntityTypeBuilder<Trail> builder) =>
            builder
                .ToTable("AuditTrails", SchemaNames.Auditing);
    }
}
