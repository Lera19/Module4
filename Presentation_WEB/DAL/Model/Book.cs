using System.Collections.Generic;

namespace DAL.Model
{
    public class Book
    {
        public Book()
        {
            Authors = new List<Author>();
        }
        public int ID { get; set; }
        public string NameBook { get; set; }
        public Category Categories { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}
