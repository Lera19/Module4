using BusinessLogics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var shopManager = new ShopManager();
            var shops = shopManager.GetAllShops();

            foreach (var shop in shops)
            {
                Console.WriteLine($"Name {shop.Name}");
                foreach (var supplier in shop.Suppliers)
                {
                    Console.WriteLine($"Name supplier { supplier.Name}");
                    foreach (var product in supplier.Products)
                    {
                        Console.WriteLine($"Product Name {product.Name}");
                    }
                }
            }
            Console.WriteLine("------------");

           // var sh = shopManager.GetFirstShop();

            Console.ReadKey();
        }
    }
}
