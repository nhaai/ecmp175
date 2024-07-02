using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LTW.Nhom1.Configuration;

namespace LTW.Nhom1.Web.Host.Startup
{
    [DependsOn(
       typeof(Nhom1WebCoreModule))]
    public class Nhom1WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Nhom1WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Nhom1WebHostModule).GetAssembly());
        }
    }
}
