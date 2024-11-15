using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie.backend
{
    public class Director : Employee
    {

        public List<Department> Departments { get; set; }

        public Director(int id, string name, string position, decimal salary)
            : base(id, name, position, salary)
        {
            Departments = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }

    }
}
