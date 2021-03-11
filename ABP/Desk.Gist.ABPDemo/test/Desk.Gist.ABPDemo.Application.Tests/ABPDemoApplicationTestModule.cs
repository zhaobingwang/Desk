using Volo.Abp.Modularity;

namespace Desk.Gist.ABPDemo
{
    [DependsOn(
        typeof(ABPDemoApplicationModule),
        typeof(ABPDemoDomainTestModule)
        )]
    public class ABPDemoApplicationTestModule : AbpModule
    {

    }
}