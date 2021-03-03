using Microsoft.AspNetCore.Mvc;
using ParsiBin.DTO.League;
using ParsiBin.DTO.Match;
using ParsiBin.DTO.Season;
using ParsiBin.DTO.StandingTable;
using ParsiBin.DTO.Team;
using ParsiBin.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParsiBin.UI.Controllers
{
    public class MatchController 
    {
        private readonly ITeamService _teamService;
        private readonly IMatchService _matchService;
        private readonly IMatchResultService _matchResultService;
        private readonly ILeagueService _leagueService;
        private readonly ISeasonService  _seasonService;

        public MatchController(ITeamService teamService, IMatchService matchService, IMatchResultService matchResultService
            ,ILeagueService leagueService, ISeasonService seasonService)
        {
            _teamService = teamService;
            _matchService = matchService;
            _matchResultService = matchResultService;
            _leagueService = leagueService;
            _seasonService = seasonService;
        }
        public async Task<List<TeamDTO>> GetTeamsListAsync(int LeagueId, int SeasonId)
        {
            return (List<TeamDTO>)await _teamService.GetList(LeagueId,SeasonId);
        }

        public async Task<int> AddNewMatchAsync(AddNewMatchDTO model, int stadium)
        {
            model.Stadium = stadium;
            return await _matchService.AddMatch(model);
        }

        public async Task<IEnumerable<TableDTO>> GetLeagueTable(int LeagueId, int SeasonId)
        {
            return await _matchResultService.GetLeagueTable(LeagueId, SeasonId);
        }

        public async Task<IEnumerable<MatchDTO>> GetCommingMatches(int LeagueId)
        {
            return await _matchService.GetCommingMatches(LeagueId);
        }

        public async Task<List<LeagueDTO>> GetLeagueList()
        {
            return (List<LeagueDTO>)await _leagueService.GetList();
        }

        public async Task<IEnumerable<SeasonDTO>> GetSeasonList(int LeagueId)
        {
            return await _seasonService.GetList(LeagueId);
        }

        public async Task<List<MatchDTO>> GetWaitingMatchesList(int LeagueId, int SeasonId)
        {
            return await _matchService.GetWaitingMatchesList(LeagueId, SeasonId);
        }

        public async Task<int> SubmitMatchResult(AddMatchResultDTO model)
        {
            return await _matchResultService.SubmitMatchResult(model);
        }
    }
}
