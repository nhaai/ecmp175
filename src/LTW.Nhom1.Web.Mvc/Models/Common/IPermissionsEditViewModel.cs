using System.Collections.Generic;
using LTW.Nhom1.Roles.Dto;

namespace LTW.Nhom1.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}