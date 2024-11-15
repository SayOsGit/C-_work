using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Zadanie.backend;

namespace Zadanie.XML
{
    [Serializable]
    [XmlRoot("Employees")]
    public class EmployeesList
    {
        [XmlElement("Employee")]
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
