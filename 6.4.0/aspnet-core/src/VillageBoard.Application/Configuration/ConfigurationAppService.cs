using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using VillageBoard.Configuration.Dto;

namespace VillageBoard.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : VillageBoardAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
