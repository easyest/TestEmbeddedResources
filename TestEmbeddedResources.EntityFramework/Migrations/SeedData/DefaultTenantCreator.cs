using System.Linq;
using TestEmbeddedResources.EntityFramework;
using TestEmbeddedResources.MultiTenancy;

namespace TestEmbeddedResources.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly TestEmbeddedResourcesDbContext _context;

        public DefaultTenantCreator(TestEmbeddedResourcesDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
