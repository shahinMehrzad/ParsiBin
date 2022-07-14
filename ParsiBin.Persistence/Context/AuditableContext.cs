using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ParsiBin.Domain.Entities;
using ParsiBin.Persistence.Enums;
using ParsiBin.Persistence.Models;

namespace ParsiBin.Persistence.Context
{
    public abstract class AuditableContext : DbContext
    {
        public DbSet<Audit> AuditLogs { get; set; }

        public AuditableContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual async Task<int> SaveChangesAsync(string? userId = null)
        {
            List<AuditEntry> auditEntries = OnBeforeSaveChanges(userId);
            int result = await base.SaveChangesAsync();
            await OnAfterSaveChanges(auditEntries);
            return result;
        }
        private List<AuditEntry> OnBeforeSaveChanges(string? userId)
        {
            ChangeTracker.DetectChanges();
            List<AuditEntry> list = new List<AuditEntry>();
            foreach (EntityEntry item in ChangeTracker.Entries())
            {
                if (item.Entity is Audit || item.State == EntityState.Detached || item.State == EntityState.Unchanged)
                {
                    continue;
                }

                AuditEntry auditEntry = new AuditEntry(item);
                auditEntry.TableName = item.Entity.GetType().Name;
                auditEntry.UserId = userId ?? "";
                list.Add(auditEntry);
                foreach (PropertyEntry property in item.Properties)
                {
                    if (property.IsTemporary)
                    {
                        auditEntry.TemporaryProperties.Add(property);
                        continue;
                    }

                    string name = property.Metadata.Name;
                    if (property.Metadata.IsPrimaryKey())
                    {
                        auditEntry.KeyValues[name] = property.CurrentValue ?? "";
                        continue;
                    }

                    switch (item.State)
                    {
                        case EntityState.Added:
                            auditEntry.AuditType = AuditType.Create;
                            auditEntry.NewValues[name] = property.CurrentValue ?? "";
                            break;
                        case EntityState.Deleted:
                            auditEntry.AuditType = AuditType.Delete;
                            auditEntry.OldValues[name] = property.OriginalValue ?? "";
                            break;
                        case EntityState.Modified:
                            if (property.IsModified)
                            {
                                auditEntry.ChangedColumns.Add(name);
                                auditEntry.AuditType = AuditType.Update;
                                auditEntry.OldValues[name] = property.OriginalValue ?? "";
                                auditEntry.NewValues[name] = property.CurrentValue ?? "";
                            }

                            break;
                    }
                }
            }

            foreach (AuditEntry item2 in list.Where((AuditEntry _) => !_.HasTemporaryProperties))
            {
                AuditLogs.Add(item2.ToAudit());
            }

            return list.Where((AuditEntry _) => _.HasTemporaryProperties).ToList();
        }

        private Task OnAfterSaveChanges(List<AuditEntry> auditEntries)
        {
            if (auditEntries == null || auditEntries.Count == 0)
            {
                return Task.CompletedTask;
            }

            foreach (AuditEntry auditEntry in auditEntries)
            {
                foreach (PropertyEntry temporaryProperty in auditEntry.TemporaryProperties)
                {
                    if (temporaryProperty.Metadata.IsPrimaryKey())
                    {
                        auditEntry.KeyValues[temporaryProperty.Metadata.Name] = temporaryProperty.CurrentValue;
                    }
                    else
                    {
                        auditEntry.NewValues[temporaryProperty.Metadata.Name] = temporaryProperty.CurrentValue;
                    }
                }

                AuditLogs.Add(auditEntry.ToAudit());
            }

            return SaveChangesAsync();
        }
    }
}
