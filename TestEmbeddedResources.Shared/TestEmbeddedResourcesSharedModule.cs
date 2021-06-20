using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Abp.Modules;
using Abp.Resources.Embedded;

namespace TestEmbeddedResources.Shared
{
    public class TestEmbeddedResourcesSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.EmbeddedResources.Sources.Add(
                new EmbeddedResourceSet(
                    "/EmbeddedContent/",
                    Assembly.GetExecutingAssembly(),
                    "TestEmbeddedResources.Shared.EmbeddedContent"
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
