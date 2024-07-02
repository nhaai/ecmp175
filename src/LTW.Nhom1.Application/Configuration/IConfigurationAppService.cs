using System.Threading.Tasks;
using LTW.Nhom1.Configuration.Dto;

namespace LTW.Nhom1.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
