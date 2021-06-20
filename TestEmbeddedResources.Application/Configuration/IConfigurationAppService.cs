using System.Threading.Tasks;
using Abp.Application.Services;
using TestEmbeddedResources.Configuration.Dto;

namespace TestEmbeddedResources.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}