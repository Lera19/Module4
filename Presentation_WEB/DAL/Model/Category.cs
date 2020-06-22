using System.Collections.Generic;

namespace DAL.Model
{
    public class Category
    {
        public int ID { get; set; }
        public string NameCategory { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
