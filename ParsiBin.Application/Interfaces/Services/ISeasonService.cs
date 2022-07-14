using ParsiBin.Application.DTOs.Season;

namespace ParsiBin.Application.Interfaces.Services
{
    public interface ISeasonService
    {
        Task<IEnumerable<SeasonDTO>> GetList(int LeagueId);
    }
}
