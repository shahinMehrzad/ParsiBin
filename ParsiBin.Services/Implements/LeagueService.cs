using Mapster;
using ParsiBin.DAL.Context;
using ParsiBin.DAL.Entities;
using ParsiBin.DTO.League;
using ParsiBin.Repository.BaseRepository;
using ParsiBin.Services.BaseServices;
using ParsiBin.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParsiBin.Services.Implements
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
