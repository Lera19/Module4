using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Models
{
    public class Employee

    {
        public Employee(string fN, string lN, string email, decimal salary, string mFN, string mLN )
        {
            FirstName = fN;
            LastName = lN;
            Email = email;
            Salary = salary;
            ManagerFirstName = mFN;
            ManagerLastName = mLN;
        }
        public string FirstName {get;set;}
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public override string ToString()
        {
            return $"Employee: {FirstName}, {LastName}, email {Email},salary {Salary}, " +
                $"and his manager : {ManagerFirstName}, {ManagerLastName}";
        }

    }
}
