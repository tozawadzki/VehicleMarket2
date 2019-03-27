namespace VehicleMarket2.Models
{
    public class OrderPosition
    {
        public int OrderPositionID { get; set; }
        public int OrderID { get; set; }
        public int CarID { get; set; }
        public int Amount { get; set; }
        public decimal OrderPrice { get; set; }

        public virtual Car kurs { get; set; }
        public virtual Order order { get; set; }
    }
}