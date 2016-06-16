using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Problem_5.Filter_Students_by_Email_Domain
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

            var sorted = names.Where(x => x.EndsWith("@gmail.com"));
            foreach (var name in sorted)
            {
                Console.WriteLine(string.Join(" ",name.Split().Take(2)));
            }
        }
    }
}
