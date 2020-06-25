
using System.Collections;
using System.Collections.Generic;
using Utils.Models;

namespace Utils.Iterfaces
{
    public interface IEmployeeRepository
    {
        IList<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        int InsertEmployees(Employee employee);
        int DeleteEmployeeById(int id);
    }
}
