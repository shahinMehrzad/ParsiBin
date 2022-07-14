using ParsiBin.Application.Interfaces.Repositories.BaseRepository;
using ParsiBin.Domain.Entities;

namespace ParsiBin.Application.Repositories
{
    public interface IMatchRepository : IBaseRepository<Match>
    {
        Task<IEnumerable<Match>> GetCommingMatches(int LeagueId);
    }
}
