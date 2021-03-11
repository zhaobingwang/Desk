using Desk.Gist.ABPDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Desk.Gist.ABPDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ABPDemoEntityFrameworkCoreDbMigrationsModule),
        typeof(ABPDemoApplicationContractsModule)
        )]
    public class ABPDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
