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

            Employee highest = Highest(emplist);
            Employee lowest = Lowest(emplist);
            double[] percentages = Percentage(emplist);

            Console.WriteLine($"Average weekly pay for all employees: {Avg(emplist):C}");
            Console.WriteLine($"Highest weekly paid employee is {highest.Name}, earning {highest.GetPay():C} a week");
            Console.WriteLine($"Lowest weekly paid employee is {lowest.Name}, earning {lowest.GetPay():C} a week");
            Console.WriteLine($"{percentages[0]:N1}% of employees are salaried. {percentages[1]:N1}% of employees are waged. {percentages[2]:N1}% of employees are part-time. ");

        }

        static Employee CreateEmployee(string line)
        {
            Employee e = null;
            if (line[0] >= '0' && line[0] <= '4')
            {
                e = Salaried.Parse(line);
            }
            else if (line[0] >= '5' && line[0] <= '7')
            {
                e = Wages.Parse(line);
            }
            else if (line[0] >= 8 && line[0] <= '9')

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
            }
            return totalPay / emplist.Count;

        }

        static Employee Highest(List<Employee> emplist)
        {
            Employee h = emplist.First();

            foreach (Employee emp in emplist)
            {
                if (emp.GetPay() > h.GetPay())
                {
                    h = emp;
                }
            }
            return h;
        }

        static Employee Lowest(List<Employee> emplist)
        {
            Employee h = emplist.First();

            foreach (Employee emp in emplist)
            {
                if (emp.GetPay() < h.GetPay())
                {
                    h = emp;
                }
            }
            return h;
        }

        static double[] Percentage(List<Employee> emplist)
        {
            double salariedCount = 0;
            double wageCount = 0;
            double partTimeCount = 0;

            foreach (Employee emp in emplist)
            {
                if (emp is Salaried)
                {
                    salariedCount += 1;
                }
                else if (emp is Wages)
                {
                    wageCount += 1;
                }
                else if (emp is PartTime)
                {
                    partTimeCount += 1;
                }
            }
            double[] result =
                {
                salariedCount/emplist.Count()* 100,
                wageCount/emplist.Count()*100, 
                partTimeCount/emplist.Count()*100
                };
            return result;
        }
    }
}
