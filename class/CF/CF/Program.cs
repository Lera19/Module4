using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var ctx = new PersonContext())
            {
                ctx.People.Add(new Person() { Age = 21, Name = "Lera" , Sex= "Girl"});
                ctx.SaveChanges();
            }
        }
    }
}
