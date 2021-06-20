using TestEmbeddedResources.EntityFramework;
using EntityFramework.DynamicFilters;

namespace TestEmbeddedResources.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TestEmbeddedResourcesDbContext _context;

        public InitialHostDbBuilder(TestEmbeddedResourcesDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
