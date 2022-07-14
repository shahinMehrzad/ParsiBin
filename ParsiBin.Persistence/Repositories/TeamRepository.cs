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
    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        private ParsibinContext _context;
        public TeamRepository(ParsibinContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Team>> GetTeamsList(int LeagueId, int SeasonId)
        {
            var result = await _context.Team
                //.Include(x => x.Stadium)
                .Include(x => x.SeasonTeams)
                .ThenInclude(x => x.Season)
                .ThenInclude(x => x.League)
                .Where(x => x.Status).OrderBy(x => x.Name).ToListAsync();
            List<Team> lstResult = new List<Team>();
            foreach (var item in result)
            {
                if (item.SeasonTeams.Where(x => x.Season.Id == SeasonId).FirstOrDefault() != null)
                {
                    lstResult.Add(new Team
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Logo = item.Logo,
                        Status = item.Status,
                        Description = item.Description,
                        //Country = item.Country,
                        //City = item.City,
                        //Stadium = item.Stadium,
                        SeasonTeams = item.SeasonTeams.Where(x => x.Season.Id == SeasonId && x.Season.League.Id == LeagueId).ToList()
                    });
                }
            }
            return lstResult.OrderBy(x => x.Name);

        }


    }
}
