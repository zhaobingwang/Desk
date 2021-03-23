using Desk.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Desk.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DeskController : AbpController
    {
        protected DeskController()
        {
            LocalizationResource = typeof(DeskResource);
        }
    }
}