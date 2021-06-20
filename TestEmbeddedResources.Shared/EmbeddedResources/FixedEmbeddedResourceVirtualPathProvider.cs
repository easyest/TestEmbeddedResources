using Abp.Dependency;
using Abp.Extensions;
using Abp.Resources.Embedded;
using Abp.Web.Mvc.Resources.Embedded;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;
using System.Web.Hosting;

namespace TestEmbeddedResources.Shared.EmbeddedResources
{
    public class FixedEmbeddedResourceVirtualPathProvider : EmbeddedResourceVirtualPathProvider, ITransientDependency
    {
        private readonly IEmbeddedResourceManager _embeddedResourceManager;
        public FixedEmbeddedResourceVirtualPathProvider(IEmbeddedResourceManager embeddedResourceManager) : base(embeddedResourceManager)
        {
            _embeddedResourceManager = embeddedResourceManager;
        }

        public override bool DirectoryExists(string virtualDir)
        {
            var resources = GetResources(virtualDir);
            if (resources != null && resources.Any())
            {
                return true;
            }

            return base.DirectoryExists(virtualDir);
        }

        public override VirtualDirectory GetDirectory(string virtualDir)
        {
            var resources = GetResources(virtualDir);
            var embeddedResourceItems = resources.ToList();
            if (embeddedResourceItems.Any())
            {
                return new ComponentsEmbeddedResourceVirtualDirectory(virtualDir, embeddedResourceItems);
            }

            var result = base.GetDirectory(virtualDir);


            return result;
        }


        private IEnumerable<EmbeddedResourceItem> GetResources(string virtualPath)
        {
            return _embeddedResourceManager.GetResources(VirtualPathUtility.ToAppRelative(virtualPath).RemovePreFix("~"));
        }
    }
}
