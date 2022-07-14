using ParsiBin.Application.Services.BaseServices;

namespace ParsiBin.Application.Services
{
    public class SeasonService : BaseService<Season>, ISeasonService
    {
        private readonly IBaseRepository<Season> _repo;

        public SeasonService(IBaseRepository<Season> repo, ParsibinContext dbContext) : base(repo, dbContext)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<SeasonDTO>> GetList(int LeagueId)
        {
            var result = await _repo.GetList(filter: filter=> filter.League.Id == LeagueId);
            return result.Adapt<List<SeasonDTO>>();
        }
    }
}
