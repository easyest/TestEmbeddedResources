using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using TestEmbeddedResources.EntityFramework;

namespace TestEmbeddedResources.Migrator
{
    [DependsOn(typeof(TestEmbeddedResourcesDataModule))]
    public class TestEmbeddedResourcesMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TestEmbeddedResourcesDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}