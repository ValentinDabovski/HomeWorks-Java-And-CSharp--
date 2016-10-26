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
            StringBuilder stringBuilder = new StringBuilder();

            var context = new SoftUniEntities();
            var employees = context.Employees
                .Where(emp => emp.EmployeeID == 147)
                .Select(emp => new
                {
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    JobTitle = emp.JobTitle,
                    ProjectsName = emp.Projects.OrderBy(p => p.Name).Select(p => p.Name).ToList()
                });

            List<string> projetNamesList = new List<string>();

            foreach (var employee in employees)
            {
                stringBuilder.AppendLine($"{employee.FirstName} {employee.LastName}, JobTitle: {employee.JobTitle},");

                foreach (var project in employee.ProjectsName)
                {
                    if (project.Count() > 1)
                    {
                       
                        stringBuilder.AppendLine($"Project: {project} ");
                    }

                    else
                    {
                        stringBuilder.AppendLine($"{employee.FirstName} {employee.LastName} JobTitle: {employee.JobTitle}, Project: {employee.ProjectsName}");
                    }
                    
                }
                
            }
            
            Console.WriteLine(stringBuilder);
        }
    }
}