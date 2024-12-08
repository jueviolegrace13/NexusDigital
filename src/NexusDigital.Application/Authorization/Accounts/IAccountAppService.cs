using Abp.Application.Services;
using NexusDigital.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace NexusDigital.Authorization.Accounts;

public interface IAccountAppService : IApplicationService
{
    Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

    Task<RegisterOutput> Register(RegisterInput input);
}
