using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace VehicleMarket2.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę kategorii")]
        [StringLength(100)]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Wprowadź opis kategorii")]
        [StringLength(100)]
        public string Description { get; set; }
        public string Photo { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}