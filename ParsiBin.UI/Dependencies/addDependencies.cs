using Microsoft.Extensions.DependencyInjection;
using ParsiBin.UI.Controllers;
using ParsiBin.UI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParsiBin.UI.Dependencies
{
    public static class Dependencies
    {
        public static IServiceCollection addDependencies(this IServiceCollection services)
        {
            services.AddSingleton<WeatherForecastService>();
            services.AddTransient<CountryController>();
            services.AddTransient<MatchController>();
            return services;
        }
    }
}
