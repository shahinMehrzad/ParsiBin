using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Data;

namespace ParsiBin.SharedKernal.Interfaces.Contexts
{
    public interface IApplicationDbContext
    {
        IDbConnection Connection { get; }
        bool HasChanges { get; }

        EntityEntry Entry(object entity);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        //DbSet<Product> Products { get; set; }
    }
}
