using System.Web.Mvc;

namespace TestEmbeddedResources.Web.Controllers
{
    public class AboutController : TestEmbeddedResourcesControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}