using Abp.AutoMapper;
using LTW.Nhom1.Roles.Dto;
using LTW.Nhom1.Web.Models.Common;

namespace LTW.Nhom1.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
