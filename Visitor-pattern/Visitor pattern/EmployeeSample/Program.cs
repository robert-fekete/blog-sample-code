using System;
using System.Collections.Generic;

namespace EmployeeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IEmployee> employees = new IEmployee[]{
                new Developer("Dave"),
                new Manager("Peter")
            };

            var visitor = new EmployeeReportGeneratingVisitor();
            foreach(var employee in employees)
            {
                SayHi(employee.DisplayName);
                employee.DoWork();
                employee.Accept(visitor);
            }

            Console.WriteLine($"Ratio: {visitor.Ratio}");
        }

        private static void SayHi(string displayName)
        {
            Console.WriteLine("Hi, " + displayName);
        }
    }
}
