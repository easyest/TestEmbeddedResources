using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using TestEmbeddedResources.EntityFramework;

namespace TestEmbeddedResources
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(TestEmbeddedResourcesCoreModule))]
    public class TestEmbeddedResourcesDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<TestEmbeddedResourcesDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
