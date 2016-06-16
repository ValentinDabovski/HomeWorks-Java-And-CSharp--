using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Filter_Students_by_Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> names = new List<string>();

            while (input != "END")
            {
                names.Add(input);
                
                input = Console.ReadLine();
            }

            var sorted = names.Where(x => x.Split()[2].StartsWith("02") || x.Split()[2].StartsWith("+3592")).ToList();

            foreach (var student in sorted)
            {
                Console.WriteLine(string.Join(" ",student.Split().Take(2)));
            }
        }
    }
}
