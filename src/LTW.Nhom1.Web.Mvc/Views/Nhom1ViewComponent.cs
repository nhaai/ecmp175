using Abp.AspNetCore.Mvc.ViewComponents;

namespace LTW.Nhom1.Web.Views
{
    public abstract class Nhom1ViewComponent : AbpViewComponent
    {
        protected Nhom1ViewComponent()
        {
            LocalizationSourceName = Nhom1Consts.LocalizationSourceName;
        }
    }
}
