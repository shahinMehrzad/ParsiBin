using ParsiBin.DAL.Entities;
using ParsiBin.Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParsiBin.Repository.Contracts
{
    public interface IMatchResultRepository : IBaseRepository<MatchResult>
    {
        Task<IEnumerable<MatchResult>> GetLeagueTable(int LeagueId, int SeasonId);
    }
}
