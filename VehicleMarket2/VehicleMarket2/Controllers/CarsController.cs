using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleMarket2.DAL;

namespace VehicleMarket2.Controllers
{
    public class CarsController : Controller
    {
        private CarsContext db = new CarsContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List(string categoryName)
        {
            var category = db.Categories.Include("Cars").Where(k => k.CategoryName.ToUpper() == categoryName.ToUpper()).FirstOrDefault();
                
            var cars = db.Cars.ToList();
            return View(cars);
        }

        public ActionResult Details(string id)
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult CategoriesMenu()
        {
            var categories = db.Categories.ToList();

            return PartialView("_CategoriesMenu", categories);
        }
    }
}