using Abp.Application.Services;
using azuretest.MultiTenancy.Dto;

namespace azuretest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

