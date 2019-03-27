using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VehicleMarket2.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        [Required(ErrorMessage = "Imię jest wymagane")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [StringLength(100)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Ulica jest wymagana")]
        [StringLength(100)]
        public string Street { get; set; }
        [Required(ErrorMessage = "Kod pocztowy jest wymagany")]
        [StringLength(7)]
        public string PostalCode { get; set; }
        public string City { get; set; }
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