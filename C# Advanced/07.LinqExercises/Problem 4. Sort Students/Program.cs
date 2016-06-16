using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Sort_Students
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
            var sorterd = names.OrderBy(x => x.Split()[1]).ThenByDescending(x => x.Split()[0]);

            foreach (var student in sorterd)
            {
                Console.WriteLine(string.Join(" ", student));
            }
        }
    }
}
