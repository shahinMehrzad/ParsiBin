using ParsiBin.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParsiBin.Repository.BaseRepository
{
    public interface IBaseRepository<T> where T : BaseEntity
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
        Task<T> GetById(int Id);
    }
}
