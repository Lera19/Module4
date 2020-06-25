using System;

namespace Utils.Models
{
    public class Order
    {
        public Order(int id, DateTime date)
        {
            OrderID = id;
            OrderDate = date;
        }
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public override string ToString()
        {
            return $"OrderID {OrderID}, ORDER DATE {OrderDate}";
        }
    }
}