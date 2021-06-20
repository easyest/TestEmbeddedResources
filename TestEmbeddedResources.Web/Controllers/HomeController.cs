using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TestEmbeddedResources.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TestEmbeddedResourcesControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}