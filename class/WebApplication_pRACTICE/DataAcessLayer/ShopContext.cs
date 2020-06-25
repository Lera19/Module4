using DataAcessLayer.Models;
using System.Data.Entity;

namespace DataAcessLayer
{
    public class ShopContext : DbContext
    {
        public ShopContext(): base("DefaultConnection")
        {
            Database.SetInitializer(new CustomInitializer());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
