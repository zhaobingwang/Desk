using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;
using Oxygen.Server.Kestrel.Implements;
using Autofac;
using Oxygen.IocModule;
using Microsoft.Extensions.Logging;
using Autofac.Extensions.DependencyInjection;

namespace ClientSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await CreateDefaultHost(args).Build().RunAsync();
        }
        static IHostBuilder CreateDefaultHost(string[] args) => new HostBuilder()
            .ConfigureWebHostDefaults(webHostBuilder =>
            {
                webHostBuilder.StartOxygenServer<OxygenStartup>((config) =>
                {
                    config.Port = 80;
                    config.PubSubCompentName = "pubsub";
                    config.StateStoreCompentName = "statestore";
                    config.TracingHeaders = "Authentication";
                });
            })
            .ConfigureContainer<ContainerBuilder>(builder =>
            {
                builder.RegisterOxygenModule();
            })
            .ConfigureLogging((hostingContext, logging) =>
            {
                logging.AddConsole();
            })
            .ConfigureServices((context, services) =>
            {
                services.AddAutofac();
            })
            .UseServiceProviderFactory(new AutofacServiceProviderFactory());
    }
}
