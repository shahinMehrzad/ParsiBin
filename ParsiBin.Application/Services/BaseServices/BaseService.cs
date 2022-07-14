using ParsiBin.Application.Interfaces.Repositories.BaseRepository;

namespace ParsiBin.Application.Services.BaseServices
{
    public class BaseService<TModel> : IBaseService<TModel>
        where TModel : BaseEntity
    {
        private readonly IBaseRepository<TModel> _repo;
        private readonly ParsibinContext _dbContext;

        public BaseService(IBaseRepository<TModel> repo, ParsibinContext dbContext)
        {
            _repo = repo;
            _dbContext = dbContext;
        }

        public virtual async Task<int> Add(TModel entity)
        {
            await _repo.Insert(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<int> AddItems(List<TModel> entity)
        {
            var objectList = entity;
            await _repo.BulkInsert(objectList);
            return await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<int> Remove(TModel entity)
        {
            await _repo.Remove(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<int> Update(TModel entity)
        {
            await _repo.Update(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<TModel> Find(long id)
        {
            var entity = await _repo.FindBy(x => x.Id == id).FirstOrDefaultAsync();
            return entity;
        }

        public virtual async Task<IEnumerable<TModel>> GetList()
        {
            var entity = await _repo.GetList();
            return entity;
        }

        public virtual async Task<IEnumerable<TModel>> GetListById(long id)
        {
            var entity = await _repo.FindBy(x => x.Id == id).ToListAsync();
            return entity;
        }

        public async Task<long> GetCountOfAll()
        {
            return await (_repo.GetQueryable()).CountAsync();
        }

    }
}
