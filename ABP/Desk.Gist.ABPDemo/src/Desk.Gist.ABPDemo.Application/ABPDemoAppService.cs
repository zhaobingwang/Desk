using System;
using System.Collections.Generic;
using System.Text;
using Desk.Gist.ABPDemo.Localization;
using Volo.Abp.Application.Services;

namespace Desk.Gist.ABPDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class ABPDemoAppService : ApplicationService
    {
        protected ABPDemoAppService()
        {
            LocalizationResource = typeof(ABPDemoResource);
        }
    }
}
