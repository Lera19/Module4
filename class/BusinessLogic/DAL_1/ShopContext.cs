using DAL_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_1
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new CustomInitializer());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
