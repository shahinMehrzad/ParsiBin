using Microsoft.Extensions.DependencyInjection;

namespace ParsiBin.SharedKernal.ServiceRegistry
{
    public static class ParsiBinServiceRegistry
    {
        public static IServiceCollection PageCustomService(this IServiceCollection service)
        {
            service.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));            
            service.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            service.AddScoped<ITeamRepository, TeamRepository>();
            service.AddScoped<IMatchResultRepository, MatchResultRepository>();
            service.AddScoped<IMatchRepository, MatchRepository>();

            service.AddScoped<ICountryService, CountryService>();
            service.AddScoped<ITeamService, TeamService>();
            service.AddScoped<IMatchService, MatchService>();
            service.AddScoped<IMatchResultService, MatchResultService>();
            service.AddScoped<ILeagueService, LeagueService>();
            service.AddScoped<ISeasonService, SeasonService>();
            return service;
        }
    }
}
