using ParsiBin.DTO.Season;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParsiBin.Services.Contracts
{
    public interface ISeasonService
    {
        Task<IEnumerable<SeasonDTO>> GetList(int LeagueId);
    }
}
