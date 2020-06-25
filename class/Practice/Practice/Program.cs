using BusinessLogicApp;
using System;


namespace Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var employeeManager = new EmployeeManager();
            var employees = employeeManager.GetAllEmployees();
            foreach(var employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine(employeeManager.DeleteEmployeeById(111));
            Console.ReadKey();
            
        }
    }
}
