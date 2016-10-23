using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniEntities
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var context = new SoftUniEntities();
            var employees = context.Employees
                .Where(emp => emp.Department.Name == "Research and Development")
                .OrderBy(emp => emp.Salary)
                .ThenByDescending(emp => emp.FirstName)
                .Select(emp => new
                {
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    DepartamentName = emp.Department.Name,
                    Salary = emp.Salary
                });

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} from {employee.DepartamentName} - {employee.Salary:F2}");
            }
        }
    }
}