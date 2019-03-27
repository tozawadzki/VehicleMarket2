using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleMarket2.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime DateOfProduction { get; set; }
        public int Mileage { get; set; }
        public int Price { get; set; }
        
        public virtual Category Category { get; set; }
    }
}