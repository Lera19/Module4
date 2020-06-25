using DataAcessLayer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace DataAcessLayer
{
    public class ShopRepository
    {
        public IList<Product> GetAllProducts()
        {
            using(var context= new ShopContext())
            {
                return context.Products.Include(product => product.Groups).ToList();  
            }
        }

        public Product GetProductID(int id)
        {
            using (var context = new ShopContext())
            {
                return context.Products.
                    Include(product => product.Groups).First(p => p.ID == id);
            }
        }
        public void UpdateProduct(Product product)
        {
            using (var context = new ShopContext())
            {
                //var exictingProduct = context.Products.First(p => p.ID == product.ID);
                //product.Groups = exictingProduct.Groups;
                //context.Products.Remove(exictingProduct);

                //context.Products.Add(product);
                context.Products.AddOrUpdate(product);
                context.SaveChanges();
            }
        }
        public void SaveProduct(Product product)
        {
            using(var context= new ShopContext())
            {
                context.Products.Add(product);

                context.SaveChanges();
            }
        }
        public void RemoveProduct(int id)
        {
            using (var context = new ShopContext())
            {
                context.Products.Remove(context.Products.First(product => product.ID ==id));

                context.SaveChanges();
                   
            }
        }
    }
}
