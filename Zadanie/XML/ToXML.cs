using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Zadanie.backend;

namespace Zadanie.XML
{
    public class ToXML
    {
        private string pathEmployee = "Employees.xml";
        private string pathSchedule = "Schedules.xml";
        public void LoadEmployeesFromXml(HRDepartment hrd)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Zadanie.XML.EmployeesList));
            using (FileStream fs = new FileStream(pathEmployee, FileMode.Open))
            {
                var employeesList = (EmployeesList)serializer.Deserialize(fs);
                hrd.GetEmployees().AddRange(employeesList.Employees);
                Console.WriteLine("Сотрудники загружены из XML.");
            }
        }

        public void LoadSchedulesFromXml(HRDepartment hrd)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Zadanie.XML.SchedulesList));
            using (FileStream fs = new FileStream(pathSchedule, FileMode.Open))
            {
                var schedulesList = (SchedulesList)serializer.Deserialize(fs);
                hrd.GetSchedules().AddRange(schedulesList.Schedules);
                Console.WriteLine("Расписание загружено из XML.");
            }
        }
        public void AddEmployee(HRDepartment hrd)
        {
            Console.Write("Введите Id сотрудника: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Введите имя сотрудника: ");
            string name = Console.ReadLine();

            Console.Write("Введите должность: ");
            string position = Console.ReadLine();

            Console.Write("Введите оклад: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Employee newEmployee = new Employee(id, name, position, salary);
            hrd.HireEmployee(newEmployee);
        }
        public void AddSchedule(HRDepartment hrd)
        {
            Console.Write("Введите должность: ");
            string position = Console.ReadLine();

            Console.Write("Введите количество ставок: ");
            int count = int.Parse(Console.ReadLine());

            Console.Write("Введите оклад: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Schedule newSchedule = new Schedule(position, count, salary);
            hrd.AddSchedule(newSchedule);
        }
        public void SaveSchedulesToXml(HRDepartment hrd)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Zadanie.XML.SchedulesList));
            using (FileStream fs = new FileStream(pathSchedule, FileMode.Create))
            {
                var schedulesList = new SchedulesList { Schedules = hrd.GetSchedules() };
                serializer.Serialize(fs, schedulesList);
                Console.WriteLine("Расписание сохранено в XML.");
            }
        }
        public void SaveEmployeesToXml(HRDepartment hrd)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Zadanie.XML.EmployeesList));
            using (FileStream fs = new FileStream(pathEmployee, FileMode.Create))
            {
                var employeesList = new EmployeesList { Employees = hrd.GetEmployees() };
                serializer.Serialize(fs, employeesList);
                Console.WriteLine("Сотрудники сохранены в XML.");
            }
        }


    }
}
