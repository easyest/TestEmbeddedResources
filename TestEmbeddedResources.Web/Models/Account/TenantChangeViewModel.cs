using Abp.AutoMapper;
using TestEmbeddedResources.Sessions.Dto;

namespace TestEmbeddedResources.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}