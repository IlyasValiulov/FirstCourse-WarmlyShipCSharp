using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Microsoft.Extensions.Configuration;

namespace ProjectWarmlyShip
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ServiceCollection services = new();
            ConfigureServices(services);
            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            Application.Run(serviceProvider.GetRequiredService<FormShipCollection>());

        }
        private static void ConfigureServices(ServiceCollection services)
        {
            string[] path = Directory.GetCurrentDirectory().Split('\\');
            string pathNeed = "";
            for (int i = 0; i < path.Length - 3; i++)
            {
                pathNeed += path[i] + "\\";
            }
            services.AddSingleton<FormShipCollection>()
            .AddLogging(option =>
            {
                option.SetMinimumLevel(LogLevel.Information);
                option.AddSerilog(new LoggerConfiguration()
                    .ReadFrom.Configuration(new ConfigurationBuilder()
                        .AddJsonFile($"{pathNeed}serilog.json")
                        .Build())
                    .CreateLogger());
            });
        }
    }
}