using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancelab
{
    public class Employee
    {
        public string id { get; set; } = "";
        public string name { get; set; } = "";
        public string address { get; set; } = "";
        public string phone { get; set; } = "";
        public long sin { get; set; } = 0;
        public string dob { get; set; } = "";
        public string dept { get; set; } = "";

        public Employee()
        {
        }
    }
}
