using ParsiBin.Application.DTOs.League;

namespace ParsiBin.Application.Interfaces.Services
{
    public interface ILeagueService
    {
        Task<IEnumerable<LeagueDTO>> GetList();
    }
}
