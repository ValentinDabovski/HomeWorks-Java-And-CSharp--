using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {

            SortedSet<string> chemicals = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input.Contains(' '))
                {
                    string[] removeEmtyLine = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    for (int j = 0; j < removeEmtyLine.Length; j++)
                    {
                        chemicals.Add(removeEmtyLine[j]);
                    }
                }

                else
                {
                    chemicals.Add(input);
                }
            }
            Console.WriteLine(string.Join(" ", chemicals));
        }
    }
}