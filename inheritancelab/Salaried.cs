using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancelab
{
    public class Salaried : Employee
    {
        public double Salary { get; set; } = 0;
        public override double GetPay()
        {
            return Salary;
        }

        public static new Salaried Parse(string s)
        {
            string[] args = s.Split(':');

            Salaried employee = new Salaried();
            employee.ID = args[0];
            employee.Name = args[1];
            employee.Address = args[2];
            employee.Phone = args[3];
            employee.SIN = long.Parse(args[4]);
            employee.DOB = args[5];
            employee.Dept = args[6];
            employee.Salary = double.Parse(args[7]);

            return employee;
        }
    }
}