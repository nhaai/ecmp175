using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LTW.Nhom1.Authorization.Roles;
using LTW.Nhom1.Authorization.Users;
using LTW.Nhom1.MultiTenancy;

namespace LTW.Nhom1.EntityFrameworkCore
{
    public class Nhom1DbContext : AbpZeroDbContext<Tenant, Role, User, Nhom1DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Nhom1DbContext(DbContextOptions<Nhom1DbContext> options)
            : base(options)
        {
        }
    }
}
