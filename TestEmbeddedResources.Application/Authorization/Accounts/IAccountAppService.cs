using System.Threading.Tasks;
using Abp.Application.Services;
using TestEmbeddedResources.Authorization.Accounts.Dto;

namespace TestEmbeddedResources.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
