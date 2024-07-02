using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LTW.Nhom1.Authorization;

namespace LTW.Nhom1
{
    [DependsOn(
        typeof(Nhom1CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Nhom1ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Nhom1AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Nhom1ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
