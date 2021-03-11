using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Desk.Gist.ABPDemo.EntityFrameworkCore
{
    [DependsOn(
        typeof(ABPDemoEntityFrameworkCoreModule)
        )]
    public class ABPDemoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ABPDemoMigrationsDbContext>();
        }
    }
}
