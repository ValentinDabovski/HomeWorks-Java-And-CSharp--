using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Students_Enrolled_in_2014_or_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> studentsStatsList = new List<string>();
            while (!input.Equals("END"))
            {
                studentsStatsList.Add(input);

                input = Console.ReadLine();
            }

            var sorted = studentsStatsList.Where(x => x.Split()[0].EndsWith("14") || x.Split()[0].EndsWith("15"));

            foreach (var student in sorted)
            {
                Console.WriteLine(string.Join(" ", student.Split().Skip(1)));
            }
        }
    }
}
