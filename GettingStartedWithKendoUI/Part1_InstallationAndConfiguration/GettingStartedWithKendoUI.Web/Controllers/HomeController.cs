using System.Web.Mvc;

namespace GettingStartedWithKendoUI.Web.Controllers {
    public class HomeController : Controller {

        public ActionResult Index() {
            ViewBag.Title = "Hello World";
            return View();
        }
    }
}