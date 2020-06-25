using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Iterfaces;
using Utils.Models;

namespace DataAccessDapper
{
    public class EmployeeRepositoryDapper : IEmployeeRepository
    {
        private readonly string connection = string.Empty;
        public EmployeeRepositoryDapper()
        {
            connection = ConfigurationManager.ConnectionStrings["HRSQLProvider"].ConnectionString;
        }
        public int DeleteEmployeeById(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                var deletionQuery = "Delete from employees where employee_id=@emp_id";

                var numOfAffectedRows = sqlConnection.Execute(deletionQuery, new { emp_id = id});
                return numOfAffectedRows;
            }
        }

        public IList<Employee> GetAllEmployees()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                var selection = "Select e.first_name, e.last_name, e.email, " +
                "e.salary, e1.first_name as 'manager_name', e1.last_name  as 'manager_last_name' from employees e, employees e1 " +
                "where e.manager_id = e1.employee_id ";
                var employees = sqlConnection.Query<Employee>(selection).AsList();
                return employees;
            }
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
