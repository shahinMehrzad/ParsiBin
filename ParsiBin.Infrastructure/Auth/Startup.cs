using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using ParsiBin.Infrastructure.Auth.Jwt;
using ParsiBin.Application.Common.Interfaces;
using ParsiBin.Infrastructure.Auth.Permissions;

namespace ParsiBin.Infrastructure.Auth
{
    internal static class Startup
    {
        internal static IServiceCollection AddAuth(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddCurrentUser()
                .AddPermissions()

                // Must add identity before adding auth!
                .AddIdentity();

            return services.AddJwtAuth(config);
        }

        internal static IApplicationBuilder UseCurrentUser(this IApplicationBuilder app) =>
            app.UseMiddleware<CurrentUserMiddleware>();

        private static IServiceCollection AddCurrentUser(this IServiceCollection services) =>
            services
                .AddScoped<CurrentUserMiddleware>()
                .AddScoped<ICurrentUser, CurrentUser>()
                .AddScoped(sp => (ICurrentUserInitializer)sp.GetRequiredService<ICurrentUser>());

        private static IServiceCollection AddPermissions(this IServiceCollection services) =>
            services
                .AddSingleton<IAuthorizationPolicyProvider, PermissionPolicyProvider>()
                .AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();
    }
}
