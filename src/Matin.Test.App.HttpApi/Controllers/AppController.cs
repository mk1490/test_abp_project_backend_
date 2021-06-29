using Matin.Test.App.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Matin.Test.App.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AppController : AbpController
    {
        protected AppController()
        {
            LocalizationResource = typeof(AppResource);
        }
    }
}