using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPCoreSpa.Configuration.Dto;

namespace ABPCoreSpa.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPCoreSpaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
