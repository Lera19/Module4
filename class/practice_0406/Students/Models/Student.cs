using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Models
{
    public class Student
    {
        public Student()
        {
            Books = new List<Book>();
        }
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        
    }
}
