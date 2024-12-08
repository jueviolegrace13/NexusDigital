using Abp.Application.Services;
using NexusDigital.MultiTenancy.Dto;

namespace NexusDigital.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}

