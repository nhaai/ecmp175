using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LTW.Nhom1.Configuration;
using LTW.Nhom1.Web;

namespace LTW.Nhom1.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Nhom1DbContextFactory : IDesignTimeDbContextFactory<Nhom1DbContext>
    {
        public Nhom1DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Nhom1DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Nhom1DbContextConfigurer.Configure(builder, configuration.GetConnectionString(Nhom1Consts.ConnectionStringName));

            return new Nhom1DbContext(builder.Options);
        }
    }
}
