using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgChart
{
    class Employee
    {
        public int Name { get; set; }
        private Employee _supervisor;
        public Employee Supervisor {
            get { } set; }
        
            
        public IList<Employee> Minion { get; set; }

        public 
    }
    class program
    {
        static void main(string[] args)
        {
        }
    }
}
