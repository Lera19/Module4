using DAL.Model;
using System.Data.Entity;

namespace DAL
{
    public class StoreContext : DbContext
    {
        public StoreContext(): base("DefaultConnection")
        {
            Database.SetInitializer(new Initializer());
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
