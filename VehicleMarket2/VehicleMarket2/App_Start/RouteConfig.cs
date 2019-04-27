using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VehicleMarket2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "CarsList", 
                url: "Category/{categoryName}",
                defaults: new {controller = "Cars", action = "List"});

            routes.MapRoute(
                name: "StronyStatyczne",
                url: "strona/{nazwa}.html",
                defaults: new { controller = "Home", action = "StronyStatyczne" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.IgnoreRoute("Glimpse.axd");
        }
    }
}
