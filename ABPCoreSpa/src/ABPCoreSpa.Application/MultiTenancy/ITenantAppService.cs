using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPCoreSpa.MultiTenancy.Dto;

namespace ABPCoreSpa.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
