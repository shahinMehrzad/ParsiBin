using Mapster;
using ParsiBin.DAL.Context;
using ParsiBin.DAL.Entities;
using ParsiBin.DTO.League;
using ParsiBin.DTO.Match;
using ParsiBin.DTO.Season;
using ParsiBin.DTO.StandingTable;
using ParsiBin.Repository.BaseRepository;
using ParsiBin.Repository.Contracts;
using ParsiBin.Services.BaseServices;
using ParsiBin.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsiBin.Services.Implements
{
    public class MatchResultService : BaseService<MatchResult>, IMatchResultService
    {
        private readonly IBaseRepository<MatchResult> _repo;
        private readonly IBaseRepository<Match> _repoMatch;
        private readonly IMatchResultRepository _repoMatchResult;
        private readonly ITeamRepository _repoTeam;
        public MatchResultService(IBaseRepository<MatchResult> repo,
            IMatchResultRepository repoMatchResult, ITeamRepository teamRepository,
            IBaseRepository<Match> repoMatch,
            ParsibinContext dbContext) : base(repo, dbContext)
        {
            _repo = repo;
            _repoMatchResult = repoMatchResult;
            _repoTeam = teamRepository;
            _repoMatch = repoMatch;
        }

        public async Task<IEnumerable<TableDTO>> GetLeagueTable(int LeagueId, int SeasonId)
        {
            var result = new List<TableDTO>();
            var teams = await _repoTeam.GetTeamsList(LeagueId, SeasonId);
            var matchResults = await _repoMatchResult.GetLeagueTable(LeagueId, SeasonId);
            //_repoTeam.
            foreach (var item in teams)
            {
                result.Add(new TableDTO
                {
                    GoalsFor = matchResults.Where(x => x.Match.HomeTeam.Id == item.Id).Select(x => x.HomeGoal).Sum() + matchResults.Where(x => x.Match.AwayTeam.Id == item.Id).Select(x => x.AwayGoal).Sum(),
                    GoalsAgainst = matchResults.Where(x => x.Match.HomeTeam.Id == item.Id).Select(x => x.AwayGoal).Sum() + matchResults.Where(x => x.Match.AwayTeam.Id == item.Id).Select(x => x.HomeGoal).Sum(),
                    League = matchResults.FirstOrDefault().Match.League.Adapt<LeagueDTO>(),
                    Logo = item.Logo,
                    Name = item.Name,
                    Id = item.Id,
                    MatchPlayed = matchResults.Where(x => x.Match.HomeTeam.Id == item.Id).Count() + matchResults.Where(x => x.Match.AwayTeam.Id == item.Id).Count(),
                    Season = matchResults.FirstOrDefault().Match.Season.Adapt<SeasonDTO>(),
                    MatchWon = matchResults.Where(x => x.Match.HomeTeam.Id == item.Id).Where(x => x.HomeGoal > x.AwayGoal).Count() + matchResults.Where(x => x.Match.AwayTeam.Id == item.Id).Where(x => x.HomeGoal < x.AwayGoal).Count(),
                    MatchLost = matchResults.Where(x => x.Match.HomeTeam.Id == item.Id).Where(x => x.HomeGoal < x.AwayGoal).Count() + matchResults.Where(x => x.Match.AwayTeam.Id == item.Id).Where(x => x.HomeGoal > x.AwayGoal).Count(),
                    MatchDrawn = matchResults.Where(x => x.Match.HomeTeam.Id == item.Id || x.Match.AwayTeam.Id == item.Id).Where(x => x.HomeGoal == x.AwayGoal).Count(),
                    Last5Match =(matchResults.Where(x => x.Match.HomeTeam.Id == item.Id || x.Match.AwayTeam.Id == item.Id).Count() > 0 )
                    ? matchResults.Where(x => x.Match.HomeTeam.Id == item.Id || x.Match.AwayTeam.Id == item.Id)
                    .OrderByDescending(x => x.Match.MatchDate).Select(x => new MatchResultDTO
                    {
                        Id = x.Id,
                        AwayGoal = x.AwayGoal,
                        HomeGoal = x.HomeGoal,
                        Match = new MatchDTO
                        {
                            Id = x.Match.Id,
                            AwayTeam = new DTO.Team.TeamDTO
                            {
                                Id = x.Match.AwayTeam.Id,
                                Logo = x.Match.AwayTeam.Logo,
                                Name = x.Match.AwayTeam.Name,
                                Stadium = new DTO.Stadium.StadiumDTO
                                {
                                    //Id = x.Match.AwayTeam.Stadium.Id,
                                    //Name = x.Match.AwayTeam.Stadium.Name,
                                    City = new DTO.City.CityDTO
                                    {
                                        //Id = x.Match.AwayTeam.Stadium.City.Id,
                                        //Name = x.Match.AwayTeam.Stadium.City.Name,
                                        Country = new DTO.Country.CountryDTO
                                        {
                                            //Id = x.Match.AwayTeam.Stadium.City.Country.Id,
                                            //Name = x.Match.AwayTeam.Stadium.City.Country.Name,
                                            //Flag = x.Match.AwayTeam.Stadium.City.Country.Flag
                                        }
                                    }
                                }
                            },
                            HomeTeam = new DTO.Team.TeamDTO
                            {
                                Id = x.Match.HomeTeam.Id,
                                Logo = x.Match.HomeTeam.Logo,
                                Name = x.Match.HomeTeam.Name,
                                Stadium = new DTO.Stadium.StadiumDTO
                                {
                                    //Id = x.Match.HomeTeam.Stadium.Id,
                                    //Name = x.Match.HomeTeam.Stadium.Name,
                                    City = new DTO.City.CityDTO
                                    {
                                        //Id = x.Match.HomeTeam.Stadium.City.Id,
                                        //Name = x.Match.HomeTeam.Stadium.City.Name,
                                        Country = new DTO.Country.CountryDTO
                                        {
                                            //Id = x.Match.HomeTeam.Stadium.City.Country.Id,
                                            //Name = x.Match.HomeTeam.Stadium.City.Country.Name,
                                            //Flag = x.Match.HomeTeam.Stadium.City.Country.Flag
                                        }
                                    }
                                }
                            },
                            League = new LeagueDTO
                            {
                                Id = x.Match.League.Id,
                                Logo = x.Match.League.Logo,
                                Name = x.Match.League.Name
                            },
                            MatchDate = x.Match.MatchDate,
                            Season = new SeasonDTO
                            {
                                Id = x.Match.Season.Id,
                                Name = x.Match.Season.Name
                            },
                            Week = x.Match.Week
                        }
                    }).Take(5).ToList() : new List<MatchResultDTO>()
                });
            }
            int i = 1;
            foreach (var item in result.OrderByDescending(x => x.Points).ThenByDescending(x => x.Goaldiffrence).ThenBy(x => x.Name))
            {
                item.Rank = i;
                i++;
            }
            return result;
        }

        public async Task<int> SubmitMatchResult(AddMatchResultDTO model)
        {
            var match = await _repoMatch.GetById(model.Match);
            MatchResult matchResult = new MatchResult();
            matchResult.AwayGoal = model.AwayGoal;
            matchResult.HomeGoal = model.HomeGoal;
            matchResult.Match = match;
            matchResult.Status = true;

            //Match Status
            match.MatchStatus = 1;
            await _repoMatch.Update(match);
            return await _repo.Insert(matchResult);
        }
    }
}
