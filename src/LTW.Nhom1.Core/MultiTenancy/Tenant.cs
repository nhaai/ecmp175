using Abp.MultiTenancy;
using LTW.Nhom1.Authorization.Users;

namespace LTW.Nhom1.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
