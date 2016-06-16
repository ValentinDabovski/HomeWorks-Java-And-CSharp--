using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01StudentsByGroup
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<int, List<string>> studentsDic = new Dictionary<int, List<string>>();

            while (input != "END")
            {
                string[] args = input.Split();
                string firstName = args[0];
                string lastName = args[1];
                int groupNumber = int.Parse(args[2]);

                if (!studentsDic.ContainsKey(groupNumber))
                {
                    studentsDic.Add(groupNumber, new List<string>());
                }

                   studentsDic[groupNumber].Add(firstName+ " " +lastName);
                 
                input = Console.ReadLine();
            }

            List<string> orderedNames = studentsDic[2].OrderBy(x => x.Split()[0]).ToList();

            foreach (var sorted in orderedNames)
            {
                Console.WriteLine(sorted);
            }
        }
    }
}

