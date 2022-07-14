using Microsoft.EntityFrameworkCore;
using ParsiBin.DAL.Context;
using ParsiBin.DAL.Entities;
using ParsiBin.DTO.StandingTable;
using ParsiBin.Repository.BaseRepository;
using ParsiBin.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsiBin.Persistence.Repositories
{
    public class MatchResultRepository : BaseRepository<MatchResult>, IMatchResultRepository
    {
        private ParsibinContext _context;

        public MatchResultRepository(ParsibinContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MatchResult>> GetLeagueTable(int LeagueId, int SeasonId)
        {
            var result = await _context.MatchResult
                .Include(x => x.Match)
                .ThenInclude(x => x.League)
                .ThenInclude(x => x.Seasons)
                .ThenInclude(x => x.SeasonTeams)
                .ThenInclude(x => x.Team)
                //.ThenInclude(x=> x.Stadium)
                //.ThenInclude(x=>x.City)
                //.ThenInclude(x=>x.Country)
                .Where(x => x.Status == true && x.Match.League.Id == LeagueId && x.Match.Season.Id == SeasonId)
                .ToListAsync();
            return result;
        }        
    }
}
