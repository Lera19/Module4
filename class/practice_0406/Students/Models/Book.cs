using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Models
{
    public class Book
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
