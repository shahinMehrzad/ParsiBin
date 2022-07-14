using ParsiBin.SharedKernel.Interfaces;
using System.Linq.Expressions;

namespace ParsiBin.Application.Interfaces.Repositories.BaseRepository
{
    public interface IBaseRepository<T> where T : IAggregateRoot
    {
        Task BulkInsert(IEnumerable<T> entities);
        Task<int> Insert(T entity);
        Task Remove(T entity);
        Task Update(T entity);
        Task BulkUpdate(IEnumerable<T> entities);

        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetQueryable();
        Task<IEnumerable<T>> GetList();
        Task<IEnumerable<T>> GetList(Expression<Func<T, bool>> filter = null);        
    }
}
