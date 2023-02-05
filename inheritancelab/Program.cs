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
                Employee employee = Employee.Parse(line);

                emplist.Add(employee);
            }

            emplist.Sort();
        }
    }           
}
