using DataAccess;
using DataAccessDapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Iterfaces;
using Utils.Models;

namespace BusinessLogicApp
{
    public class EmployeeManager
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeManager()
        {
            employeeRepository = new EmployeeRepositoryDapper();
                //new EmployeeRepositoryADO();
        }

        public IList<Employee> GetAllEmployees()
        {
            return employeeRepository.GetAllEmployees();

        }
        public int DeleteEmployeeById(int empId)
        {
            return employeeRepository.DeleteEmployeeById(empId);

        }
    }
}
