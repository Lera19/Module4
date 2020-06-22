using DAL.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class Initializer : DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var listOfCategory = new List<Category>()
            {
                new Category() {NameCategory="Crime"},
                new Category() {NameCategory="Detective"},
                new Category() {NameCategory="Fantasy"},
                new Category() {NameCategory="Romance"}
            };

            var listOfAuthor = new List<Author>()
            {  
                new Author() {First_Name="Anna", Last_Name="Koval"},
                new Author() {First_Name="Valeri", Last_Name="Kravch"},
                new Author() {First_Name="Anton", Last_Name="Petrenko"},
                new Author() {First_Name="Ala", Last_Name="Nosova"},
                new Author() {First_Name="Olya", Last_Name="Osinova"}
            };
            var listOfBook = new List<Book>()
            {
                new Book() {
                    NameBook="Karaban", 
                    Categories=listOfCategory.Where(n=>n.NameCategory=="Crime").FirstOrDefault(), 
                    Authors=listOfAuthor.Where(n=> n.Last_Name=="Osinova").ToList()},
                
                new Book() {
                    NameBook="Harry",
                    Categories=listOfCategory.Where(n=>n.NameCategory=="Fantasy").FirstOrDefault(),
                    Authors=listOfAuthor.Where(n=>n.Last_Name=="Nosova").ToList()},
                
                new Book() {
                    NameBook="7",
                    Categories=listOfCategory.Where(n=>n.NameCategory=="Detective").FirstOrDefault(),
                    Authors=listOfAuthor.Where(n=>n.Last_Name=="Kravch").ToList()},

                new Book() {
                    NameBook="Love",
                    Categories=listOfCategory.Where(n=>n.NameCategory=="Romance").FirstOrDefault(),
                    Authors=listOfAuthor.Where(n=>n.Last_Name=="Petrenko").ToList()},
            };

            context.Authors.AddRange(listOfAuthor);
            context.Categories.AddRange(listOfCategory);
            context.Books.AddRange(listOfBook);

            context.SaveChanges();
        }
    }
}
