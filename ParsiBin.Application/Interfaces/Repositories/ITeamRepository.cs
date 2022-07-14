using ParsiBin.Application.Interfaces.Repositories.BaseRepository;
using ParsiBin.Domain.Entities;

namespace ParsiBin.Application.Repositories
{
    public interface ITeamRepository : IBaseRepository<Team>
    {
        Task<IEnumerable<Team>> GetTeamsList(int LeagueId, int SeasonId);
    }    
}
