using VehicleMarket2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleMarket2.Models;

namespace VehicleMarket2.Controllers
{
    public class HomeController : Controller
    {
        public CarsContext db = new CarsContext();

        public ActionResult Index()
        {
            var listOfCategories = db.Categories.ToList();
            return View();
        }
    }
}