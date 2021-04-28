using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Sinks.MSSqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desk.Gist.EntityFrameworkCore.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Log.Logger = new LoggerConfiguration()
            // .WriteTo
            // .MSSqlServer(
            //     connectionString: "Server=localhost;Database=LogDb;Integrated Security=SSPI;",
            //     sinkOptions: new MSSqlServerSinkOptions { TableName = "LogEvents" })
            // .CreateLogger();

            Log.Logger = new LoggerConfiguration()
              .WriteTo.Console()
              .WriteTo
              .SQLite("..\\..\\..\\blogging.db")
              .MinimumLevel.Information()
              .CreateLogger();

            Log.Information("This informational message will be written to SQLite database");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                              .UseSerilog();
                });
    }
}
