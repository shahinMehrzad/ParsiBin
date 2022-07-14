using ParsiBin.Application.DTOs.Country;
using ParsiBin.Application.Interfaces.Repositories.BaseRepository;
using ParsiBin.Application.Interfaces.Services;
using ParsiBin.Application.Services.BaseServices;

namespace ParsiBin.Application.Services
{
    public class CountryService : BaseService<Country>, ICountryServices
    {
        private readonly IBaseRepository<Country> _repo;
        public CountryService(IBaseRepository<Country> repo, ParsibinContext dbContext) : base(repo, dbContext)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<CountryDTO>> GetList()
        {
            var x = await _repo.GetList(filter: filter => filter.Cities == new List<City>().Where(x => x.Stadiums.Contains(new Stadium { Id = 6 })));
            var result = await _repo.GetList();
            return result.Adapt<List<CountryDTO>>();
        }

    }
}
