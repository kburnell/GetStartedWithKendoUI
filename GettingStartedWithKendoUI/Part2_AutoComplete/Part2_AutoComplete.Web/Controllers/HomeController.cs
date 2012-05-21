using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Part2_AutoComplete.Web.Models;

namespace Part2_AutoComplete.Web.Controllers {

    public class HomeController : Controller {

        [HttpGet]
        public ActionResult Index() {
            return View(new Manufacturer{Id = 1, Name = "Aston Martin"});
        }

        [HttpPost]
        public ActionResult Index(Manufacturer manufacturer) {
            ViewBag.Message = string.Format("You selected \"{0}\" and sent it to the server!", manufacturer.Name);
            return View();
        }

        [HttpPost]
        public JsonResult GetManufacturers() {
            string searchValue = Request.Params["filter[filters][0][value]"];
            IList<Manufacturer> manufacturers = BuildManufacturersList()
                .Where(x => x.Name.StartsWith(searchValue, StringComparison.InvariantCultureIgnoreCase)).ToList();
            return Json(manufacturers);
        }

        private IList<Manufacturer> BuildManufacturersList() {
            IList<Manufacturer> manufacturers = new List<Manufacturer>();
            manufacturers.Add(new Manufacturer {Id = 1, Name = "Aston Martin"});
            manufacturers.Add(new Manufacturer {Id = 2, Name = "Audi"});
            manufacturers.Add(new Manufacturer {Id = 3, Name = "Buggati"});
            manufacturers.Add(new Manufacturer {Id = 4, Name = "BMW"});
            manufacturers.Add(new Manufacturer {Id = 5, Name = "Chevrolet"});
            manufacturers.Add(new Manufacturer {Id = 6, Name = "Ferrari"});
            manufacturers.Add(new Manufacturer {Id = 7, Name = "Ford"});
            manufacturers.Add(new Manufacturer {Id = 8, Name = "Lamborghini"});
            manufacturers.Add(new Manufacturer {Id = 9, Name = "Mazda"});
            manufacturers.Add(new Manufacturer {Id = 10, Name = "McLaren"});
            manufacturers.Add(new Manufacturer {Id = 11, Name = "Mercedes Benz"});
            manufacturers.Add(new Manufacturer {Id = 12, Name = "Porsche"});
            return manufacturers;
        } 
    }
}