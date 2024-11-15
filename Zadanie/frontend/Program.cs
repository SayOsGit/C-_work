using System;
using System.Runtime.ConstrainedExecution;
using System.Xml;
using System.Xml.Linq;
using Zadanie.backend;
using Zadanie.XML;
class Program
{
    static void Main()
    {
        ToXML newDoc = new ToXML();
        Department dep = new Department("Development");
        var hrDepartment = new HRDepartment(dep);
        //newDoc.AddSchedule(hrDepartment);
        //newDoc.SaveSchedulesToXml(hrDepartment);
        newDoc.LoadSchedulesFromXml(hrDepartment);
        //List<Schedule> sch = hrDepartment.GetSchedules();
        //foreach (var i in sch)
        //{
        //    Console.WriteLine($"{i.Position} {i.Count} {i.Salary}");
        //}
        newDoc.AddEmployee(hrDepartment);
        
        newDoc.SaveEmployeesToXml(hrDepartment);
        //newDoc.LoadEmployeesFromXml(hrDepartment);
        List<Employee> emp = hrDepartment.GetEmployees();
        foreach (var i in emp)
        {
            Console.WriteLine($"{i.Id} {i.Id} {i.Position} {i.Salary}");
        }




    }
}