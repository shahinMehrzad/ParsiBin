using ParsiBin.DTO.League;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParsiBin.Services.Contracts
{
    public interface ILeagueService
    {
        Task<IEnumerable<LeagueDTO>> GetList();
    }
}
