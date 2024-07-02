using System.Collections.Generic;
using System.Linq;
using LTW.Nhom1.Roles.Dto;
using LTW.Nhom1.Users.Dto;

namespace LTW.Nhom1.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
