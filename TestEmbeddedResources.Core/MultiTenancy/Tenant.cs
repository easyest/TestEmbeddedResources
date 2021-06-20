using Abp.MultiTenancy;
using TestEmbeddedResources.Authorization.Users;

namespace TestEmbeddedResources.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}