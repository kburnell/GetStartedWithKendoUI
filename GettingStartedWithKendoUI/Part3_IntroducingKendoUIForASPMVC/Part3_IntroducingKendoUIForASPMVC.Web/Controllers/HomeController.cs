using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Part3_IntroducingKendoUIForASPMVC.Web.Models;

namespace Part3_IntroducingKendoUIForASPMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(new MyModel());
        }

    }
}
