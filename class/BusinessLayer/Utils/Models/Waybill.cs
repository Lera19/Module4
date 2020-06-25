namespace Utils.Models
{
    public class Waybill
    {
        public Waybill(int row_id, string customer, string ship, string city)
        {
            ID = row_id;
            CustomerName = customer;
            ShipName = ship;
            City = city;
        }
        public int ID { get; set; }
        public string City { get; set; }
        public string ShipName { get; set; }
        public string CustomerName { get; set; }

        public override string ToString()
        {
            return $"Information order {ID}, {City}, {ShipName}, {CustomerName}";
        }
    }
}