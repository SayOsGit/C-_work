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
    [XmlRoot("Schedules")]
    public class SchedulesList
    {
        [XmlElement("Schedule")]
        public List<Schedule> Schedules { get; set; }  = new List<Schedule>();
    }
}
