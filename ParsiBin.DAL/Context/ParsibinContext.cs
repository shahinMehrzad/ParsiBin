using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ParsiBin.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Context
{
    public class ParsibinContext : DbContext
    {        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlServer(@"Server=.;Initial Catalog=ParsiBin;Integrated Security=True;");
        }

        #region DBSet
        public DbSet<League> League { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Stadium> Stadium { get; set; }
        public DbSet<Season> Season { get; set; }
        public DbSet<Coach> Coach { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Match> Match { get; set; }
        public DbSet<MatchResult> MatchResult { get; set; }
        public DbSet<SeasonTeams> SeasonTeams { get; set; }
        public DbSet<TeamCoach> TeamCoach { get; set; }
        public DbSet<TeamPlayers> TeamPlayers { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<PlayerPosition> PlayerPositions { get; set; }
        public DbSet<MatchResultDetail> MatchResultDetail { get; set; }
        public DbSet<ActionType> ActionType { get; set; }
        public DbSet<MatchResultState> MatchResultState { get; set; }
        #endregion
    }
}
