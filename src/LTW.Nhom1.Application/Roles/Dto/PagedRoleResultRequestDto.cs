using Abp.Application.Services.Dto;

namespace LTW.Nhom1.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

