using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancelab
    {
        public class Wages : Employee
        {
            public double Rate { get; set; } = 0;
            public double Hours { get; set; } = 0;
            public override double GetPay()
            {
                double pay = 0;
                if (Hours <= 40)
            {
                pay = Rate * Hours;
            }
                else
            {
                double extra = Hours - 40;
                pay = (40 * Rate) + (extra * Rate * 1.5);

            }
                return pay;
            }

            public static new Wages Parse(string s)
            {
                string[] args = s.Split(':');

            Wages employee = new Wages();
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
