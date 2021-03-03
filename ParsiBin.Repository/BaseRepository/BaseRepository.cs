using Microsoft.EntityFrameworkCore;
using ParsiBin.DAL.Context;
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
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly DbSet<T> _entities;
        private readonly ParsibinContext _context;

        public BaseRepository(ParsibinContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public async Task BulkInsert(IEnumerable<T> entities)
        {
            await _entities.AddRangeAsync(entities);
        }

        public async Task BulkUpdate(IEnumerable<T> entities)
        {
            _entities.UpdateRange(entities);
            await SaveChangesAsync();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public async Task<IEnumerable<T>> GetList()
        {
            return await _entities.Where(x => x.Status).ToListAsync();
        }

        public async Task<T> GetById(int Id)
        {
            return await _entities.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public IQueryable<T> GetQueryable()
        {
            return _entities;
        }

        public async Task<int> Insert(T entity)
        {
            entity.CreateDate = DateTime.Now;
            await _entities.AddAsync(entity);
            return await SaveChangesAsync();
        }

        public async Task Remove(T entity)
        {
            if (entity == null)
                throw new Exception("entity null exception");
            entity.Status = false;
            await SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            if (entity == null)
                throw new Exception("entity null exception");
            _entities.Update(entity);
            await SaveChangesAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetList(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ?
                await _context.Set<T>().Where(x=>x.Status == true).ToListAsync() :
                await _context.Set<T>().Where(filter).Where(x => x.Status == true).ToListAsync();
        }
    }
}
