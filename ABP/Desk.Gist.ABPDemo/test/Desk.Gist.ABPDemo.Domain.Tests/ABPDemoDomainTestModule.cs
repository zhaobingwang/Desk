using Desk.Gist.ABPDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Desk.Gist.ABPDemo
{
    [DependsOn(
        typeof(ABPDemoEntityFrameworkCoreTestModule)
        )]
    public class ABPDemoDomainTestModule : AbpModule
    {

    }
}