using ParsiBin.DTO.Match;
using ParsiBin.DTO.StandingTable;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParsiBin.Services.Contracts
{
    public interface IMatchResultService
    {
        Task<IEnumerable<TableDTO>> GetLeagueTable(int LeagueId, int SeasonId);
        Task<int> SubmitMatchResult(AddMatchResultDTO model);
    }
}
