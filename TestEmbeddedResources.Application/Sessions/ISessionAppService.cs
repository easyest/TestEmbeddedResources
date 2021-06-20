using System.Threading.Tasks;
using Abp.Application.Services;
using TestEmbeddedResources.Sessions.Dto;

namespace TestEmbeddedResources.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
