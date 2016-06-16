using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Students_by_First_and_Last_Name
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> namesList = new List<string>();

            while (input != "END")
            {
                namesList.Add(input);

                input = Console.ReadLine();
            }

            var sorted = namesList.Where(x => x.Split()[0].CompareTo(x.Split()[1]) == -1);

            foreach (var sort in sorted)
            {
                Console.WriteLine(sort);
            }

        }
    }
}
