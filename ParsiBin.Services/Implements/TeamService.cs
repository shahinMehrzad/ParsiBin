using Mapster;
using ParsiBin.DAL.Context;
using ParsiBin.DAL.Entities;
using ParsiBin.DTO.Team;
using ParsiBin.Repository.BaseRepository;
using ParsiBin.Repository.Contracts;
using ParsiBin.Services.BaseServices;
using ParsiBin.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParsiBin.Services.Implements
{
    public class TeamService : BaseService<Team>, ITeamService
    {
        private readonly IBaseRepository<Team> _repo;
        private readonly ITeamRepository _repoTeam;
        public TeamService(IBaseRepository<Team> repo, ITeamRepository teamRepository, ParsibinContext dbContext) : base(repo, dbContext)
        {
            _repo = repo;
            _repoTeam = teamRepository;
        }

        public async Task<IEnumerable<TeamDTO>> GetList(int LeagueId, int SeasonId)
        {
            List<TeamDTO> lst = new List<TeamDTO>();
            var result = await _repoTeam.GetTeamsList(LeagueId,SeasonId);
            foreach(var item in result)
            {
                lst.Add(new TeamDTO
                {
                    Id = item.Id,
                    Logo = item.Logo,
                    Name = item.Name,
                    Stadium = new DTO.Stadium.StadiumDTO
                    {
                        //Name = item.Stadium.Name,
                        //Id = item.Stadium.Id
                    }
                });
            }
            return lst;
            //return result.Adapt<IEnumerable<TeamDTO>>();
        }                
    }
}
