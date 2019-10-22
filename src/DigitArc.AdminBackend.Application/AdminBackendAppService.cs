using System;
using System.Collections.Generic;
using System.Text;
using DigitArc.AdminBackend.Localization;
using Volo.Abp.Application.Services;

namespace DigitArc.AdminBackend
{
    /* Inherit your application services from this class.
     */
    public abstract class AdminBackendAppService : ApplicationService
    {
        protected AdminBackendAppService()
        {
            LocalizationResource = typeof(AdminBackendResource);
        }
    }
}
