using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LTW.Nhom1.EntityFrameworkCore;
using LTW.Nhom1.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LTW.Nhom1.Web.Tests
{
    [DependsOn(
        typeof(Nhom1WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class Nhom1WebTestModule : AbpModule
    {
        public Nhom1WebTestModule(Nhom1EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Nhom1WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Nhom1WebMvcModule).Assembly);
        }
    }
}