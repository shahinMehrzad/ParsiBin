using Mapster;
using ParsiBin.DAL.Context;
using ParsiBin.DAL.Entities;
using ParsiBin.DTO.League;
using ParsiBin.DTO.Match;
using ParsiBin.DTO.Team;
using ParsiBin.Repository.BaseRepository;
using ParsiBin.Repository.Contracts;
using ParsiBin.Services.BaseServices;
using ParsiBin.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParsiBin.Services.Implements
{
    public class MatchService : BaseService<Match>, IMatchService
    {
        #region CTOR
        private readonly IBaseRepository<Match> _repo;
        private readonly IBaseRepository<Team> _repoTeam;
        private readonly IBaseRepository<League> _repoLeague;
        private readonly IBaseRepository<Season> _repoSeason;
        private readonly IBaseRepository<Stadium> _repoStadium;
        private readonly IMatchRepository _repoMatch;

        public MatchService(IBaseRepository<Match> repo,
            IBaseRepository<Team> repoTeam, IBaseRepository<League> repoLeague, IBaseRepository<Season> repoSeason,
            IBaseRepository<Stadium> repoSatdium, IMatchRepository matchRepository, ParsibinContext dbContext) : base(repo, dbContext)
        {
            _repo = repo;
            _repoLeague = repoLeague;
            _repoTeam = repoTeam;
            _repoStadium = repoSatdium;
            _repoSeason = repoSeason;
            _repoMatch = matchRepository;
        }
        #endregion

        public async Task<int> AddMatch(AddNewMatchDTO model)
        {
            var Hometeam = await _repoTeam.GetById(model.HomeTeam);
            var AwayTeam = await _repoTeam.GetById(model.AwayTeam);
            var League = await _repoLeague.GetById(model.League);
            var Season = await _repoSeason.GetById(model.Season);
            var Stadium = await _repoStadium.GetById(model.Stadium);
            Match match = new Match()
            {
                HomeTeam = Hometeam,
                AwayTeam = AwayTeam,
                League = League,
                MatchStatus = (model.MatchDate > DateTime.Now) ? 0 : 1,
                Season = Season,
                Stadium = Stadium,
                Status = true,
                Week = model.Week,
                MatchDate = model.MatchDate
            };
            return await _repo.Insert(match);
        }

        public async Task<IEnumerable<MatchDTO>> GetCommingMatches(int LeagueId)
        {
            try
            {
                var lstResult = new List<MatchDTO>();
                //var result = await _repo.GetList(filter: filter => filter.MatchDate >= DateTime.Now && filter.League.Id == LeagueId);
                var result = await _repoMatch.GetCommingMatches(LeagueId);
                foreach (var item in result)
                {
                    lstResult.Add(new MatchDTO
                    {
                        AwayTeam = new TeamDTO{ 
                             Id = item.AwayTeam.Id,
                             Logo = item.AwayTeam.Logo,
                             Name = item.AwayTeam.Name,
                             Stadium = new DTO.Stadium.StadiumDTO { 
                                //Id = item.AwayTeam.Stadium.Id,
                                //Name = item.AwayTeam.Stadium.Name,
                                City = new DTO.City.CityDTO
                                {
                                    //Id = item.AwayTeam.Stadium.Id,
                                    //Name = item.AwayTeam.Stadium.Name                                    
                                }
                             } 
                        },
                        HomeTeam = new TeamDTO{
                            Id = item.HomeTeam.Id,
                            Logo = item.HomeTeam.Logo,
                            Name = item.HomeTeam.Name,
                            Stadium = new DTO.Stadium.StadiumDTO
                            {
                                //Id = item.HomeTeam.Stadium.Id,
                                //Name = item.HomeTeam.Stadium.Name,
                                City = new DTO.City.CityDTO
                                {
                                    //Id = item.HomeTeam.Stadium.Id,
                                    //Name = item.HomeTeam.Stadium.Name
                                }
                            }
                        },
                        League = new LeagueDTO
                        {
                            Id = item.League.Id,
                            Name = item.League.Name,
                            Logo = item.League.Logo,
                            Description = item.League.Description
                        },
                        MatchDate = item.MatchDate,
                        MatchStatus = item.MatchStatus,
                        Week = item.Week
                    });
                }
                return lstResult;
            }
            catch(Exception e)
            {
                return new List<MatchDTO>();
            }
        }

        public async Task<List<MatchDTO>> GetWaitingMatchesList(int LeagueId, int SeasonId)
        {            
            var lstResult = new List<MatchDTO>();
            var result = await _repo.GetList(filter: filter => filter.MatchStatus == 0 && filter.MatchDate < DateTime.Now && filter.League.Id == LeagueId && filter.Season.Id == SeasonId);
            foreach (var item in result)
            {
                lstResult.Add(new MatchDTO
                {
                    AwayTeam = new TeamDTO
                    {
                        Id = item.AwayTeam.Id,
                        Logo = item.AwayTeam.Logo,
                        Name = item.AwayTeam.Name,
                        Stadium = new DTO.Stadium.StadiumDTO
                        {
                            //Id = item.AwayTeam.Stadium.Id,
                            //Name = item.AwayTeam.Stadium.Name,
                            City = new DTO.City.CityDTO
                            {
                                //Id = item.AwayTeam.Stadium.Id,
                                //Name = item.AwayTeam.Stadium.Name
                            }
                        }
                    },
                    HomeTeam = new TeamDTO
                    {
                        Id = item.HomeTeam.Id,
                        Logo = item.HomeTeam.Logo,
                        Name = item.HomeTeam.Name,
                        Stadium = new DTO.Stadium.StadiumDTO
                        {
                            //Id = item.HomeTeam.Stadium.Id,
                            //Name = item.HomeTeam.Stadium.Name,
                            City = new DTO.City.CityDTO
                            {
                                //Id = item.HomeTeam.Stadium.Id,
                                //Name = item.HomeTeam.Stadium.Name
                            }
                        }
                    },
                    League = new LeagueDTO
                    {
                        Id = item.League.Id,
                        Name = item.League.Name,
                        Logo = item.League.Logo,
                        Description = item.League.Description
                    },
                    MatchDate = item.MatchDate,
                    MatchStatus = item.MatchStatus,
                    Week = item.Week,
                    Id = item.Id
                });
            }
            return lstResult;
        }
    }
}
