using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Letters__Symbols__Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;

            ulong sumOfLetters = 0;
            ulong sumOfNumbers = 0;
            ulong sumOfSymbols = 0;
            ulong symbolCount = 0;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().ToLower();
                input.ToCharArray();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!char.IsLetterOrDigit(input[j]) && !char.IsWhiteSpace(input[j]))
                    {
                        symbolCount++;
                    }

                    else if (char.IsLetter(input[j]))
                    {
                        sumOfLetters += ((ulong)input[j] - '`') * 10;
                    }

                    else if (char.IsNumber(input[j]))
                    {
                        sumOfNumbers += ((ulong)input[j] - '0') * 20;
                    }
                }
            }

            sumOfSymbols += symbolCount;
            sumOfSymbols *= 200;

            Console.WriteLine(sumOfLetters);
            Console.WriteLine(sumOfNumbers);
            Console.WriteLine(sumOfSymbols);
        }
    }
}
