using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TestEmbeddedResources.Configuration.Dto;

namespace TestEmbeddedResources.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TestEmbeddedResourcesAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
