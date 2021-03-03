
using ParsiBin.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParsiBin.Services.BaseServices
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
