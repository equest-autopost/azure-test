using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace azuretest.Controllers
{
    public abstract class azuretestControllerBase: AbpController
    {
        protected azuretestControllerBase()
        {
            LocalizationSourceName = azuretestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
