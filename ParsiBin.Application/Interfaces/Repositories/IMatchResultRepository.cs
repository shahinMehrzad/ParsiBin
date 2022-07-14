using ParsiBin.Application.Interfaces.Repositories.BaseRepository;
using ParsiBin.Domain.Entities;

namespace ParsiBin.Application.Repositories
{
    public interface IMatchResultRepository : IBaseRepository<MatchResult>
    {
        Task<IEnumerable<MatchResult>> GetLeagueTable(int LeagueId, int SeasonId);
    }
}
