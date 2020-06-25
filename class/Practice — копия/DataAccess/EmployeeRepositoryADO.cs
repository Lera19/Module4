using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Iterfaces;
using Utils.Models;

namespace DataAccess
{
    public class EmployeeRepositoryADO : IEmployeeRepository

    {
        private readonly string connection= string.Empty;
        public EmployeeRepositoryADO()
        {
            connection = ConfigurationManager.ConnectionStrings["HRSQLProvider"].ConnectionString;
        }
        public int DeleteEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAllEmployees()
        {
            var employeesList = new List<Employee>();
            var selection = "Select e.first_name, e.last_name, e.email, " +
                "e.salary, e1.first_name, e1.last_name from employees e, employees e1 " +
                "where e.manager_id = e1.employee_id ";
            var adapter = new SqlDataAdapter(selection, connection);

            var employeesSet = new DataSet();
            adapter.Fill(employeesSet, "Employee");
            foreach(DataRow row in employeesSet.Tables["Employee"].Rows)
            {
                employeesList.Add(new Employee(
                    (string)row[0], 
                    (string)row[1], 
                    (string)row[2], 
                    (decimal)row[3], 
                    (string)row[4], 
                    (string)row[5]));
            }

            return employeesList;
        }

        public Employee GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public int InsertEmployees(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
