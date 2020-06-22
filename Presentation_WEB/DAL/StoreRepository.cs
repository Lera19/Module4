using DAL.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DAL
{
    public class StoreRepository
    {
        public IList<Book> GetAllBooks()
        {
            using (var context = new StoreContext())
            {
                return context.Books.Include(b => b.Categories).Include(a => a.Authors).ToList();
            }
        }
        public void UpdateBook(Book book)
        {
            using (var context = new StoreContext())
            {
                context.Books.AddOrUpdate(book);
                context.SaveChanges();
            }
        }
        public void AddBook(Book book)
        {
            using (var context = new StoreContext())
            {
                context.Books.Add(book);
                context.SaveChanges();
            }
        }
        public void RemoveBook(int id)
        {
            using (var context = new StoreContext())
            {
                context.Books.Remove(context.Books.First(b => b.ID == id));
                context.SaveChanges();
            }
        }
        public Book GetBookID(int id)
        {
            using (var context = new StoreContext())
            {
                return context.Books.
                    Include(b => b.Categories).Include(a=>a.Authors).First(p => p.ID == id);
            }
        }
    }
}
