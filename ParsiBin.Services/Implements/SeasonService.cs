using Mapster;
using ParsiBin.DAL.Context;
using ParsiBin.DAL.Entities;
using ParsiBin.DTO.Season;
using ParsiBin.Repository.BaseRepository;
using ParsiBin.Services.BaseServices;
using ParsiBin.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParsiBin.Services.Implements
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
