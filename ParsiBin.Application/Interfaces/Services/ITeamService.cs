using ParsiBin.Application.DTOs.Team;

namespace ParsiBin.Application.Interfaces.Services
{
    public interface ITeamService
    {
        Task<IEnumerable<TeamDTO>> GetList(int LeagueId, int SeasonId);
    }
}
