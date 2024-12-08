using Abp.Authorization;
using Abp.Runtime.Session;
using NexusDigital.Configuration.Dto;
using System.Threading.Tasks;

namespace NexusDigital.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : NexusDigitalAppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}
