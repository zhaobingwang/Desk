using Desk.Gist.ABPDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Desk.Gist.ABPDemo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ABPDemoPageModel : AbpPageModel
    {
        protected ABPDemoPageModel()
        {
            LocalizationResourceType = typeof(ABPDemoResource);
        }
    }
}