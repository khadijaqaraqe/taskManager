using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using taskManager.Configuration.Dto;

namespace taskManager.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : taskManagerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
