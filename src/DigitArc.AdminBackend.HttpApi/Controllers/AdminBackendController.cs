using DigitArc.AdminBackend.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DigitArc.AdminBackend.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AdminBackendController : AbpController
    {
        protected AdminBackendController()
        {
            LocalizationResource = typeof(AdminBackendResource);
        }
    }
}