using Students.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class StudentsContext : DbContext
    {
        public StudentsContext(string conString) : base(conString)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
