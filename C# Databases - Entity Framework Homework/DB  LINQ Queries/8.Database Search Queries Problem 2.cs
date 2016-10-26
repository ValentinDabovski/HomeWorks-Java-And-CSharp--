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
            StringBuilder stringBuilder = new StringBuilder();

            var adress = context.Addresses
                .OrderByDescending(employeeCount => employeeCount.Employees.Count()).Take(10)
                .OrderByDescending(address => address.Town.Name)
                .Select(address => new
                {
                    Address = address.AddressText,
                    TownName = address.Town.Name,
                    EmployeeCount = address.Employees.Count()
                });


            foreach (var a in adress)
            {
                stringBuilder.AppendLine($"{a.Address}, {a.TownName} - {a.EmployeeCount} employees");
            }
            
            Console.WriteLine(stringBuilder);
        }
    }
}