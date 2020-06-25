using DAL_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_1
{
    public class CustomInitializer : CreateDatabaseIfNotExists<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var products = new List<Product>()
            {
                new Product() {Name="Milk"},
                new Product() {Name="Water"}
            };
            var supplier = new Supplier() { Name = "Supplier1", Products= products};
            var shop = new Shop() { Name = "ATB" };
            shop.Suppliers.Add(supplier);

            context.Products.AddRange(products);
            context.Suppliers.Add(supplier);
            context.Shops.Add(shop);

            context.SaveChanges();
        }
    }
    
}
