using Volo.Abp.Modularity;

namespace Desk
{
    [DependsOn(
        typeof(DeskApplicationModule),
        typeof(DeskDomainTestModule)
        )]
    public class DeskApplicationTestModule : AbpModule
    {

    }
}