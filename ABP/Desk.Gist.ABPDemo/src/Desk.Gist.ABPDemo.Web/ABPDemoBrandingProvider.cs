using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Desk.Gist.ABPDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class ABPDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ABPDemo";
    }
}
