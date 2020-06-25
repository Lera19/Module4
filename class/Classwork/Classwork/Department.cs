using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    public class Department
    {
        public Department(int id, string name)
        {
            DepartmentId = id;
            DepartmentName = name;

        }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public override string ToString()
        {
            return $"Department id: {DepartmentId} name: {DepartmentName}";
        }
    }
}
