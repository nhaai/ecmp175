using System.Threading.Tasks;
using Abp.Application.Services;
using LTW.Nhom1.Sessions.Dto;

namespace LTW.Nhom1.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
