using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancelab
{
    public class PartTime : Employee
    {
        public double Rate { get; set; } = 0;
        public double Hours { get; set; } = 0;
        public override double GetPay()
        {
            return Rate * Hours;
        }

        public static new PartTime Parse(string s)
        {
            string[] args = s.Split(':');

            PartTime employee = new PartTime();
            employee.ID = args[0];
            employee.Name = args[1];
            employee.Address = args[2];
            employee.Phone = args[3];
            employee.SIN = long.Parse(args[4]);
            employee.DOB = args[5];
            employee.Dept = args[6];
            employee.Rate = double.Parse(args[7]);
            employee.Hours = double.Parse(args[8]);

            return employee;
        }
    }
}