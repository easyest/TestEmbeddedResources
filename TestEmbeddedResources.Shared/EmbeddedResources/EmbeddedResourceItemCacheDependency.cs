using System;
using System.Web.Caching;

namespace TestEmbeddedResources.Shared.EmbeddedResources
{
    public class EmbeddedResourceItemCacheDependency : CacheDependency
    {
        public EmbeddedResourceItemCacheDependency()
        {
            SetUtcLastModified(DateTime.MinValue);
        }
    }
}
