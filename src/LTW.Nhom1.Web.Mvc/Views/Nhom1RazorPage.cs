using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace LTW.Nhom1.Web.Views
{
    public abstract class Nhom1RazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected Nhom1RazorPage()
        {
            LocalizationSourceName = Nhom1Consts.LocalizationSourceName;
        }
    }
}
