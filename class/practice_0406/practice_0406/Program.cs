using Students;
using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace practice_0406
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new StudentsContext("adress connect");

            var studs = ctx.Students.Where(x=>x.Name.Length<=7).ToList();

            foreach(var stud in studs)
            {
                Console.WriteLine($"Name : {stud.Name} {stud.ID}");

                    foreach(var book in stud.Books)
                    {
                        Console.WriteLine($"Book id {book.Id} name: {book.Name}");
                    }
               
            }

            studs[0].Books.Add(new Book { Name = "Book1" });
            studs[0].Books.First().Name = "New Name";  ////good

          //  new Book { Name = "Name" }; //EntFrame ничего не знает о книгах в данній момент

            ctx.SaveChanges();


            var allStuds = GetAll();
            foreach(var stud in allStuds)
            {
                stud.Name = "Updated";

            }
            ctx.SaveChanges(); // ничего не происходит без него
        }

        public static IEnumerable<Student> GetAll()
        {
            var ctx = new StudentsContext("adress connect");
            return ctx.Students.ToList();
        }
    }
}


//var ctx = new StudentsContext("adress connect");

//var stud1 = ctx.Students.Where(x => x.Name.Length <= 7);

//var stud2 = stud1.Where(x => x.ID > 2);

//var stud3 = stud1.ToList();

//stud2.Where(x => x.ID > 4);

//            Console.WriteLine(stud1.First().Name);