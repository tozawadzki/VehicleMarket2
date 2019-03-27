using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleMarket2.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal Price { get; set; }

        List<OrderPosition> OrderPosition { get; set; }

    }

    public enum OrderStatus
    {
       New,
       Realized
    }
}