using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using azuretest.Configuration.Dto;

namespace azuretest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : azuretestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
