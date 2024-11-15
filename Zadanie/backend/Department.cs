using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie.backend
{
    public class Department
    {
        public string Name { get; set; }
        public Employee Head { get; set; }
        public List<Employee> Employees { get; set; }
        public Department(string name)
        {
            Name = name;
            Employees = new List<Employee>();
        }
        public Department()
        {
         
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            employee.Department = this;
        }
        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
            employee.Department = null;
        }
    }
}
