using VehicleMarket2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleMarket2.Models;
using VehicleMarket2.ViewModels;

namespace VehicleMarket2.Controllers
{
    public class HomeController : Controller
    {
        public CarsContext db = new CarsContext();

        public ActionResult Index()
        {
            var listOfCategories = db.Categories.ToList();

            var news = db.Cars.Where(a => !a.Hidden).OrderByDescending(a=>a.WhenAdded).Take(3).ToList();

            var supercars = db.Cars.Where(a => !a.Hidden && a.Supercar).OrderBy(a => Guid.NewGuid()).Take(3).ToList();

            var vm = new HomeViewModel(listOfCategories, news, supercars);
          

            return View(vm);
        }

        public ActionResult StronyStatyczne(string nazwa)
        {
            return View(nazwa);
        }
    }
}