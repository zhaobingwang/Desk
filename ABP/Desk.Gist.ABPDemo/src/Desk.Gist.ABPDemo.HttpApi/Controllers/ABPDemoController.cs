using Desk.Gist.ABPDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Desk.Gist.ABPDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ABPDemoController : AbpController
    {
        protected ABPDemoController()
        {
            LocalizationResource = typeof(ABPDemoResource);
        }
    }
}