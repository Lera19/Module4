using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice30
{
    public class Program
    {
        public static void Main(string[] args)
        {
          ////  ModelFirst()
            using (var context = new HumanResourseEntities())
            {
                var employeesList = context.employees.ToList();
                foreach(var emp in employeesList)
                {
                    Console.WriteLine($"Name {emp.first_name} and LastName {emp.last_name}");
                }
            }
        }
    }
}
