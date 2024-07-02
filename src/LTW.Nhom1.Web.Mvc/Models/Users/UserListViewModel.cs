using System.Collections.Generic;
using LTW.Nhom1.Roles.Dto;

namespace LTW.Nhom1.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
