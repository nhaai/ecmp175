using Abp.Authorization;
using LTW.Nhom1.Authorization.Roles;
using LTW.Nhom1.Authorization.Users;

namespace LTW.Nhom1.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
