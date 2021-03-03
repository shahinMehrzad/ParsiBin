using ParsiBin.DAL.Entities;
using ParsiBin.DTO.Team;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParsiBin.Services.Contracts
{
    public interface ITeamService
    {
        Task<IEnumerable<TeamDTO>> GetList(int LeagueId, int SeasonId);
    }
}
