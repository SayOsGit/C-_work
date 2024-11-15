using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Zadanie.backend
{
    public class HRDepartment
    {
        private List<Schedule> _schedules;
        public GeneralDirector GDirector;
        public Department MyDepartment;
        private List<Employee> _employees;
        public HRDepartment(GeneralDirector gDirector, Department department)
        {
            GDirector = gDirector;
            MyDepartment = department;
            _schedules = new List<Schedule>();
            _employees = new List<Employee>();
        }
        public HRDepartment(Department department)
        {
            GDirector = new GeneralDirector(100, "Alex", "General director", 1000000);
            MyDepartment = department;
            _schedules = new List<Schedule>();
            _employees = new List<Employee>();
        }
        public void AddSchedule(Schedule schedule)
        {
            _schedules.Add(schedule);
        }

        public void HireEmployee(Employee employee)
        {
            foreach (var schedule in _schedules)
            {
                if (schedule.Position == employee.Position && schedule.Count > 0 && schedule.Salary >= employee.Salary)
                {
                    employee.Department = MyDepartment;
                    _employees.Add(employee);

                    Console.WriteLine($"{employee.Name} принят на должность {employee.Position}");
                    schedule.Count--;
                    return;
                }
            }

            Console.WriteLine($"Нет вакансий для должности {employee.Position}");
        }

        public void FireEmployee(Employee employee)
        {
            if (employee.Department != null)
            {
                employee.Department.RemoveEmployee(employee);
                _employees.Remove(employee);
                Console.WriteLine($"{employee.Name} уволен.");
            }
        }

        public void MoveEmployee(Employee employee, Department newDepartment)
        {
            if (employee.Department != null)
            {
                employee.Department.RemoveEmployee(employee);
            }
            newDepartment.AddEmployee(employee);

            Console.WriteLine($"{employee.Name} переведен в отдел {newDepartment.Name}.");
        }
        public List<Employee> GetEmployees()
        {
            return _employees;
        }
        public List<Schedule> GetSchedules()
        {
            return _schedules;
        }
    }
}
