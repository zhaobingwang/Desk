using Desk.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Desk
{
    [DependsOn(
        typeof(DeskEntityFrameworkCoreTestModule)
        )]
    public class DeskDomainTestModule : AbpModule
    {

    }
}