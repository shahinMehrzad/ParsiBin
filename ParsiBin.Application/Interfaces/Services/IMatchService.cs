using ParsiBin.Application.DTOs.Match;

namespace ParsiBin.Application.Interfaces.Services
{
    public interface IMatchService
    {
        Task<int> AddMatch(AddNewMatchDTO model);
        Task<IEnumerable<MatchDTO>> GetCommingMatches(int LeagueId);
        Task<List<MatchDTO>> GetWaitingMatchesList(int LeagueId, int SeasonId);
    }
}
