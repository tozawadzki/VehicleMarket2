using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehicleMarket2.Models;

namespace VehicleMarket2.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Car> News { get; set; }
        public IEnumerable<Car> Supercars { get; set; }

        public HomeViewModel(IEnumerable<Category> categories, IEnumerable<Car> news, IEnumerable<Car> supercars)
        {
            Categories = categories;
            News = news;
            Supercars = supercars;
        }
    }
}