using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LTW.Nhom1.Controllers;

namespace LTW.Nhom1.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : Nhom1ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
