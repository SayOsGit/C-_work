using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie.backend
{
    [Serializable]
    public class Schedule
    {
        public string Position { get; set; }
        public int Count { get; set; }
        public decimal Salary { get; set; }

        public Schedule(string position, int count, decimal salary)
        {
            Position = position;
            Count = count;
            Salary = salary;
        }
        public Schedule() { 
            
        }
    }
}
