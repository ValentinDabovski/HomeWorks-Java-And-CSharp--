using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var symbolCountDict = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!symbolCountDict.ContainsKey(input[i]))
                {
                    symbolCountDict.Add(input[i], 0);
                }
                symbolCountDict[input[i]]++;
            }

            foreach (var item in symbolCountDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
