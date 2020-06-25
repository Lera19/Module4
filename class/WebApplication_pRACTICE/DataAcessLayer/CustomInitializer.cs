using DataAcessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class CustomInitializer : DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var listOfGroups = new List<Group>()
            { 
                new Group() {Name ="Alco"},
                new Group() {Name ="Seeds"},
                new Group() {Name ="FURNITURE"}

            };
            var bread = new Product() { Name = "Bread" };
            bread.Groups.Add(listOfGroups.Find(g => g.Name == "Seeds"));

            var beer = new Product() { Name = "slavy" };
            beer.Groups.Add(listOfGroups.First());

            context.Products.AddRange(new Product[] { beer, bread });
            context.Groups.AddRange(listOfGroups);

            context.SaveChanges();

            // base.Seed(context);
        }
    }
}
