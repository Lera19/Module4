using BusinessLayer;
using System;
using Utils.Models;

namespace PersistanceLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var manager = new Manager();
            var waybills = manager.GetInfoAboutWayb();

            foreach (var s in waybills)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(manager.UpdateWaybills(3));
            Console.WriteLine(manager.InsertOrders(new Order(5, DateTime.Parse("17/10/2016"))));
            Console.WriteLine(manager.DeleteOrderById(5));

            Console.ReadKey();
        }
    }
}