using Abp.AutoMapper;
using LTW.Nhom1.Sessions.Dto;

namespace LTW.Nhom1.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
