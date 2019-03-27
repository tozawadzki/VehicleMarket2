using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VehicleMarket2.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="Wprowadź markę pojazdu")]
        [StringLength(100)]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Wprowadź model pojazdu")]
        [StringLength(100)]
        public string Model { get; set; }
        public DateTime DateOfProduction { get; set; }
        public int Mileage { get; set; }
        public decimal Price { get; set; }
        public bool Supercar { get; set; }

        public virtual Category Category { get; set; }
    }
}