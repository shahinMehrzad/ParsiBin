namespace ParsiBin.Application.Services.BaseServices
{
    public interface IBaseService<TModel>
       where TModel : BaseEntity
    {
        Task<int> Add(TModel entity);
        Task<int> AddItems(List<TModel> entity);
        Task<int> Remove(TModel entity);
        Task<int> Update(TModel entity);

        Task<TModel> Find(long id);
        Task<IEnumerable<TModel>> GetList();
        Task<IEnumerable<TModel>> GetListById(long id);

        Task<long> GetCountOfAll();
    }
}
