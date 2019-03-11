using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Sample.TaskSystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TaskSystemControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}