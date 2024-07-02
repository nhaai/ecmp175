using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LTW.Nhom1.Configuration.Dto;

namespace LTW.Nhom1.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Nhom1AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
