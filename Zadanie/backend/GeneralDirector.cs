using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie.backend
{
    public class GeneralDirector : Employee
    {
        public List<Director> Directors;

        public GeneralDirector(int id, string name, string position, decimal salary)
            : base(id, name, position, salary)
        {
            Directors = new List<Director>();
        }

        public void AddDirector(Director director)
        {
            Directors.Add(director);
        }
    }
}
