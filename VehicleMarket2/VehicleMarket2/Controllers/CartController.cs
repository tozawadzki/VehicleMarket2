﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VehicleMarket2.Controllers
{
    public class CartController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddToCart(string id)
        {
            return View();
        }
    }
}