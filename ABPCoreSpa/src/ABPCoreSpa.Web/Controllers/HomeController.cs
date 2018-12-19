using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ABPCoreSpa.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPCoreSpaControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}