using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace NexusDigital.Controllers
{
    public abstract class NexusDigitalControllerBase : AbpController
    {
        protected NexusDigitalControllerBase()
        {
            LocalizationSourceName = NexusDigitalConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
