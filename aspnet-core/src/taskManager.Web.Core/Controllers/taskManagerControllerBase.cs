using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace taskManager.Controllers
{
    public abstract class taskManagerControllerBase: AbpController
    {
        protected taskManagerControllerBase()
        {
            LocalizationSourceName = taskManagerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
