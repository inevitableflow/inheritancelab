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

        public virtual double GetPay()
        {
            return 0;
        }
        public static Employee Parse(string s)
        {
            string[] args = s.Split(':');

            Employee employee = new Employee();
            employee.ID = args[0];
            employee.Name = args[1];
            employee.Address = args[2];
            employee.Phone = args[3];
            employee.SIN = long.Parse(args[4]);
            employee.DOB = args[5];
            employee.Dept = args[6];

            return employee;
        }


    }
}
