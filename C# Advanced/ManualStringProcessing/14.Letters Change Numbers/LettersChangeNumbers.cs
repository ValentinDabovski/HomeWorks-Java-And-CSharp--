using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Letters_Change_Numbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] {' ', '\t'},StringSplitOptions.RemoveEmptyEntries);
            decimal firstletterPosition = 0;
            decimal secondLetterPosition = 0;
            decimal resultFromLetterPoitions = 0;
            decimal sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string letterNUmberPair = input[i];
                char firstLetter = letterNUmberPair[0];
                decimal numberFromString = decimal.Parse(letterNUmberPair.Substring(1, letterNUmberPair.Length - 2));
                char lastLetter = letterNUmberPair[letterNUmberPair.Length - 1];

                if (char.IsUpper(firstLetter))
                {
                    firstletterPosition = firstLetter - 64;
                    numberFromString = numberFromString / firstletterPosition;

                }

                else if (char.IsLower(firstLetter))
                {
                    firstletterPosition = firstLetter - 96;
                    numberFromString = numberFromString * firstletterPosition;
                }

                if (char.IsUpper(lastLetter))
                {
                    secondLetterPosition = lastLetter - 64;
                    numberFromString = numberFromString - secondLetterPosition;
                    
                }

                else if (char.IsLower(lastLetter))
                {
                    secondLetterPosition = lastLetter - 96;
                    numberFromString = numberFromString + secondLetterPosition;
                    

                }

                sum += numberFromString;
              
            }
            Console.WriteLine("{0:F2}",sum);
           
        }
    }
}
