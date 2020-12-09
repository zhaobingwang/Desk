using Desk.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Desk.Win
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }
        public IConfiguration Configuration { get; private set; }
        public App()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();

            //Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(Configuration).CreateLogger();

            var services = new ServiceCollection();
            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            var serilogLogger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Warning)
                .MinimumLevel.Override("System", Serilog.Events.LogEventLevel.Error)
                //.WriteTo.SQLite("C:\\LocalDB\\SQLite\\Desk.db")
                .WriteTo.SQLite(Configuration.GetConnectionString("SQLite.Log"))
                .CreateLogger();
            services.AddLogging(x =>
            {
                x.AddSerilog(logger: serilogLogger, dispose: true);
            });

            services.AddDbContext<DeskDbContext>(options =>
            {
                options.UseSqlite(Configuration.GetConnectionString("SQLite"));
            });
            services.Configure<AppSettings>(Configuration.GetSection(nameof(AppSettings)));

            services.AddSingleton<MainWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = ServiceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
