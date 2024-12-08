using Abp.Application.Services;
using NexusDigital.Sessions.Dto;
using System.Threading.Tasks;

namespace NexusDigital.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
