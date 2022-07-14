using ParsiBin.Application.Interfaces.Repositories.BaseRepository;
using ParsiBin.Application.Services.BaseServices;

namespace ParsiBin.Application.Services
{
    public class LeagueService : BaseService<League>, ILeagueService
    {
        private readonly IBaseRepository<League> _repo;

        public LeagueService(IBaseRepository<League> repo, ParsibinContext dbContext) : base(repo, dbContext)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<LeagueDTO>> GetList()
        {
            var result = await  _repo.GetList();
            return result.Adapt<List<LeagueDTO>>();
        }
    }
}
