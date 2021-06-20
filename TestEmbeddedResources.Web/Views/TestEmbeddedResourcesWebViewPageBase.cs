using Abp.Web.Mvc.Views;

namespace TestEmbeddedResources.Web.Views
{
    public abstract class TestEmbeddedResourcesWebViewPageBase : TestEmbeddedResourcesWebViewPageBase<dynamic>
    {

    }

    public abstract class TestEmbeddedResourcesWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TestEmbeddedResourcesWebViewPageBase()
        {
            LocalizationSourceName = TestEmbeddedResourcesConsts.LocalizationSourceName;
        }
    }
}