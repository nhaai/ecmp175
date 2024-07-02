using System.Collections.Generic;
using LTW.Nhom1.Roles.Dto;

namespace LTW.Nhom1.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
