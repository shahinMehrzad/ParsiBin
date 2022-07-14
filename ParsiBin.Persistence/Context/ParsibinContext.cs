using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ParsiBin.Application.Common.Events;
using ParsiBin.Application.Common.Interfaces;
using ParsiBin.Domain.Entities;
using ParsiBin.Persistence.Configuration;
using ParsiBin.Persistence.DatabaseSetting;
using System.Data;

namespace ParsiBin.Persistence.Context
{
    public class ParsibinContext : BaseDbContext
    {
        public ParsibinContext(DbContextOptions options, ICurrentUser currentUser, ISerializerService serializer, IOptions<DatabaseSettings> dbSettings, IEventPublisher events)
        : base(options, currentUser, serializer, dbSettings, events)
        {
        }

        //private readonly IAuthenticatedUserService _authenticatedUser;

        //public ParsibinContext(DbContextOptions<ParsibinContext> options, IAuthenticatedUserService authenticatedUser) : base(options)
        //{
        //    _authenticatedUser = authenticatedUser;
        //}

        #region DBSet
        public DbSet<League> League => Set<League>();
        public DbSet<Team> Team => Set<Team>();
        public DbSet<Country> Country => Set<Country>();
        public DbSet<City> City => Set<City>();
        public DbSet<Stadium> Stadium => Set<Stadium>();
        public DbSet<Season> Season  => Set<Season>();
        public DbSet<Coach> Coach => Set<Coach>();
        public DbSet<Player> Player => Set<Player>();
        public DbSet<Match> Match => Set<Match>();
        public DbSet<MatchResult> MatchResult => Set<MatchResult>();
        public DbSet<SeasonTeams> SeasonTeams => Set<SeasonTeams>();
        public DbSet<TeamCoach> TeamCoach => Set<TeamCoach>();
        public DbSet<TeamPlayers> TeamPlayers => Set<TeamPlayers>();
        public DbSet<Position> Position => Set<Position>();
        public DbSet<PlayerPosition> PlayerPositions => Set<PlayerPosition>();
        public DbSet<MatchResultDetail> MatchResultDetail => Set<MatchResultDetail>();
        public DbSet<ActionType> ActionType => Set<ActionType>();
        public DbSet<MatchResultState> MatchResultState => Set<MatchResultState>();
        public DbSet<Audit> Audit => Set<Audit>();
        #endregion

        //public IDbConnection Connection => Database.GetDbConnection();
        //public bool HasChanges => ChangeTracker.HasChanges();

        

        protected override void OnModelCreating(ModelBuilder builder)
        {           
            base.OnModelCreating(builder);
            builder.HasDefaultSchema(SchemaNames.Catalog);
        }
    }
}
