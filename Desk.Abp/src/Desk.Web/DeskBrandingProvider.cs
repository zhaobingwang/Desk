using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Desk.Web
{
    [Dependency(ReplaceServices = true)]
    public class DeskBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Desk";
    }
}
