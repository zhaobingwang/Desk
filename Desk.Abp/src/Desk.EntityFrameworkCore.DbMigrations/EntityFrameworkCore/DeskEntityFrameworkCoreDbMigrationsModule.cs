using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Desk.EntityFrameworkCore
{
    [DependsOn(
        typeof(DeskEntityFrameworkCoreModule)
        )]
    public class DeskEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DeskMigrationsDbContext>();
        }
    }
}
