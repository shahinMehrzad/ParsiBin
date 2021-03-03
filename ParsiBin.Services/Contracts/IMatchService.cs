using ParsiBin.DTO.Match;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParsiBin.Services.Contracts
{
    public interface IMatchService
    {
        Task<int> AddMatch(AddNewMatchDTO model);
        Task<IEnumerable<MatchDTO>> GetCommingMatches(int LeagueId);
        Task<List<MatchDTO>> GetWaitingMatchesList(int LeagueId, int SeasonId);
    }
}
