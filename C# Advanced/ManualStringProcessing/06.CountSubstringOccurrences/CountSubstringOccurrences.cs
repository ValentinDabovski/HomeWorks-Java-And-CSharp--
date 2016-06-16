using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string searcher = Console.ReadLine();
            int counter = 0;
            string substringInput = string.Empty;

            int searcherLength = searcher.Length;

            for (int i = 0; i < input.Length; i++)
            {
                if (i + searcherLength < input.Length)
                {
                    substringInput = input.Substring(i, searcherLength).ToLower();

                }
                else
                {
                    substringInput = input.Substring(i).ToLower();
                }

                if (substringInput == searcher.ToLower())
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
