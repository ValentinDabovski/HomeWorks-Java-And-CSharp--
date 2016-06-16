using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Excellent_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> studentsStatsList = new List<string>();

            while (input !="END")
            {
                studentsStatsList.Add(input);

                input = Console.ReadLine();
            }

            var sorted = studentsStatsList.Where(x => x.Contains("6")).ToList();

            foreach (var student in sorted)
            {
                Console.WriteLine(string.Join(" ",student.Split().Take(2)));
            }
        }
    }
}
