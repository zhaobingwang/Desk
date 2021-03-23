using Desk.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Desk.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DeskPageModel : AbpPageModel
    {
        protected DeskPageModel()
        {
            LocalizationResourceType = typeof(DeskResource);
        }
    }
}