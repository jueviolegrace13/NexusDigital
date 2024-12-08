using NexusDigital.Configuration.Dto;
using System.Threading.Tasks;

namespace NexusDigital.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
