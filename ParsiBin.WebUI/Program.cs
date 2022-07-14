using ParsiBin.WebUI.Configurations;
using Serilog;

namespace ParsiBin.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Log.Information("Server Booting Up...");

            try
            {
                var builder = WebApplication.CreateBuilder(args);

                // Add services to the container.
                builder.Services.AddRazorPages();

                builder.Host.AddConfigurations();
                builder.Host.UseSerilog((_, config) =>
                {
                    config.WriteTo.Console()
                    .ReadFrom.Configuration(builder.Configuration);
                });

                builder.Services.AddInfrastructure(builder.Configuration);
                builder.Services.AddApplication();

                var app = builder.Build();

            }
            catch (Exception ex) when (!ex.GetType().Name.Equals("StopTheHostException", StringComparison.Ordinal))
            {
                Log.Fatal(ex, "Unhandled exception");
            }
            finally
            {
                Log.Information("Server Shutting down...");
                Log.CloseAndFlush();
            }


            

            

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}