using ParsiBin.DAL.Entities;
using ParsiBin.Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParsiBin.Repository.Contracts
{
    public interface ITeamRepository : IBaseRepository<Team>
    {
        Task<IEnumerable<Team>> GetTeamsList(int LeagueId, int SeasonId);
    }    
}
