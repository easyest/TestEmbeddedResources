using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TestEmbeddedResources.MultiTenancy.Dto;

namespace TestEmbeddedResources.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
