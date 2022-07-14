using Microsoft.EntityFrameworkCore;
using ParsiBin.DAL.Context;
using ParsiBin.DAL.Entities;
using ParsiBin.Repository.BaseRepository;
using ParsiBin.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsiBin.Persistence.Repositories
{
    public class MatchRepository : BaseRepository<Match>, IMatchRepository
    {
        private ParsibinContext _context;

        public MatchRepository(ParsibinContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Match>> GetCommingMatches(int LeagueId)
        {
            return await _context.Match
                .Include(x=>x.HomeTeam)
                .Include(x=>x.AwayTeam)
                .Where(x => x.Status && x.MatchDate >= DateTime.Now).ToListAsync();
        }
    }
}
