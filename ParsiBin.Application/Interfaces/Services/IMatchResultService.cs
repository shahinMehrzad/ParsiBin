using ParsiBin.Application.DTOs.Match;
using ParsiBin.Application.DTOs.StandingTable;

namespace ParsiBin.Application.Interfaces.Services
{
    public interface IMatchResultService
    {
        Task<IEnumerable<TableDTO>> GetLeagueTable(int LeagueId, int SeasonId);
        Task<int> SubmitMatchResult(AddMatchResultDTO model);
    }
}
