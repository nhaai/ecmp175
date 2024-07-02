using Abp.Application.Services;
using LTW.Nhom1.MultiTenancy.Dto;

namespace LTW.Nhom1.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

