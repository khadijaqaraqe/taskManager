using Abp.Application.Services;
using Abp.Application.Services.Dto;
using taskManager.MultiTenancy.Dto;

namespace taskManager.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

