using System.Collections.Generic;
using System.Collections;

namespace VehicleMarket2.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}