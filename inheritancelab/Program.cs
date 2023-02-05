using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace inheritancelab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\15875\source\repos\inheritancelab\inheritancelab\res\employees.txt"; // args[0];
            List<Employee> emplist = new List<Employee>();

            foreach (string line in System.IO.File.ReadLines(path))
            {
                Employee employee = CreateEmployee(line);

                emplist.Add(employee);
            }

            Console.WriteLine($"Average weekly pay for all employees: {Avg(emplist)}" );

        }

        static Employee CreateEmployee(string line)
        {
            Employee e = null;
            if (line[0] >= '0' && line[0] <= '4')
            {
               e = Salaried.Parse(line);
            } else if (line[0] >= '5' && line[0] <= '7')
            {
                e = Wages.Parse(line);
            } else if (line[0] >= 8 && line[0] <= '9')

            {
                e = PartTime.Parse(line);
            }
            return e;
        }
        static double Avg(List<Employee> emplist)
        {
            double totalPay = 0;
            foreach (Employee emp in emplist)
            {
                totalPay += emp.GetPay();
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.GetPay());
            }
            return totalPay / emplist.Count;

        }
    }
}
