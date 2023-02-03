using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancelab
{
    public class Employee
    {
        public string ID { get; set; } = "";
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string Phone { get; set; } = "";
        public long SIN { get; set; } = 0;
        public string DOB { get; set; } = "";
        public string Dept { get; set; } = "";

        public Employee()
        {
        }
    }
}
