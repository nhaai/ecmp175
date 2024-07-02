using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LTW.Nhom1.Controllers
{
    public abstract class Nhom1ControllerBase: AbpController
    {
        protected Nhom1ControllerBase()
        {
            LocalizationSourceName = Nhom1Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
