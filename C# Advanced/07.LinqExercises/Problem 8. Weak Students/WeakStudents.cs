using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Weak_Students
{
    class WeakStudents
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> studentsList = new List<string>();
            while (input != "END")
            {
                studentsList.Add(input);
                input = Console.ReadLine();
            }

            var sorted = studentsList.Select(x => x);

            foreach (var student in sorted)
            {
                Console.WriteLine(string.Join(" ",student));
            }
        }
    }
}
