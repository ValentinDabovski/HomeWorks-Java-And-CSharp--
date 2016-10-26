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
                .Where(emp => emp.Projects
                .Any(p => p.StartDate.Year >= 2001 && p.StartDate.Year <= 2003))
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    Projects = e.Projects
                                   .Where(p => p.StartDate.Year >= 2001 && p.StartDate.Year <= 2003)
                                   .Select(p => new

                                   {
                                       p.Name,
                                       p.StartDate,
                                       p.EndDate
                                   }),
                    ManagerName = e.FirstName + " " + e.LastName
                });


            foreach (var emp in employees)
            {
                Console.WriteLine($"Name: {emp.FirstName} {emp.LastName}");

                foreach (var project in emp.Projects)
                {
                    Console.WriteLine($"    {project.Name}");
                }
            }
        }
    }
}