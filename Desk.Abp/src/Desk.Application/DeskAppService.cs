using System;
using System.Collections.Generic;
using System.Text;
using Desk.Localization;
using Volo.Abp.Application.Services;

namespace Desk
{
    /* Inherit your application services from this class.
     */
    public abstract class DeskAppService : ApplicationService
    {
        protected DeskAppService()
        {
            LocalizationResource = typeof(DeskResource);
        }
    }
}
