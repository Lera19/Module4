using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
