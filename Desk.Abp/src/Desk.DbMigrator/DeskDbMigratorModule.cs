using Desk.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Desk.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DeskEntityFrameworkCoreDbMigrationsModule),
        typeof(DeskApplicationContractsModule)
        )]
    public class DeskDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
