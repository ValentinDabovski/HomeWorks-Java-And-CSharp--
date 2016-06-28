using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Company_Roster
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                string[] inputLines = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string name = inputLines[0];
                decimal salary = decimal.Parse(inputLines[1]);
                string position = inputLines[2];
                string departament = inputLines[3];

                var employee = new Employee(name, salary, position, departament);

                if (inputLines.Length == 5)
                {
                    if (inputLines[4].Contains("@"))
                    {
                        string email = inputLines[4];
                        employee.Email = email;
                    }

                    else
                    {
                        employee.Age = int.Parse(inputLines[4]);
                    }
                    
                }

                else if (inputLines.Length > 5)
                {
                    string email = inputLines[4];
                    int age = int.Parse(inputLines[5]);

                    employee.Age = age;
                    employee.Email = email;
                }
                employees.Add(employee);
                
            }

            var sorted = employees.GroupBy(x => x.Departament).Select(y => new
            {
                Departament = y.Key,
                Salary = y.Average(s => s.Salary),
                employeesList = y.OrderByDescending(e => e.Salary)
            }).OrderByDescending(x => x.Salary).FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {sorted.Departament}");
            foreach (var empl in sorted.employeesList)
            {
                Console.WriteLine($"{empl.Name} {empl.Salary:F2} {empl.Email} {empl.Age}");
                
            }
           
        }
    }
}
