using Desk.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk.Win
{
    static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IConfiguration configuration;
            var builderConfig = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
            configuration = builderConfig.Build();

            var serilogLogger = new LoggerConfiguration()
                   .MinimumLevel.Information()
                   .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Warning)
                   .MinimumLevel.Override("System", Serilog.Events.LogEventLevel.Error)
                   .WriteTo.SQLite("C:\\LocalDB\\SQLite\\Desk.db")
                   .CreateLogger();


            //MessageBox.Show(configuration.GetSection("AppName").Value);

            var builder = new HostBuilder()
             .ConfigureServices((hostContext, services) =>
             {
                 services.AddSingleton<Home>();
                 services.AddLogging(x =>
                 {
                     x.SetMinimumLevel(LogLevel.Debug);
                     x.AddSerilog(logger: serilogLogger, dispose: true);
                 });

                 services.AddDbContext<DeskDbContext>(option =>
                 {
                     option.UseSqlite(configuration.GetConnectionString("SQLite"));
                 });
             });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var service = serviceScope.ServiceProvider;
                try
                {
                    var home = service.GetRequiredService<Home>();
                    Application.Run(home);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
