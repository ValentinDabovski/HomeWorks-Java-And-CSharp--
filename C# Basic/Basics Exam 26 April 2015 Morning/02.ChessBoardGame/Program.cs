using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChessBoardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int blackScore = 0;
            int whiteScore = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if ( i >= n*n)
                {
                    break;
                }

                else if (i % 2 == 0 && char.IsUpper(input[i]))
                {
                    whiteScore += input[i];
                }

                else if (i % 2 == 0 && char.IsLetterOrDigit(input[i]))
                {
                    blackScore += input[i];
                }

                else if (i % 2 != 0 && char.IsUpper(input[i]))
                {
                    blackScore += input[i];
                }
                else if (i % 2 != 0 && char.IsLetterOrDigit(input[i]))
                {
                    whiteScore += input[i];
                }
            }
            

            if (blackScore == whiteScore)
            {
                Console.WriteLine("Equal result: {0}", whiteScore);
            }

            else
            {
                Console.WriteLine(
                    "The winner is: {0} team",
                    whiteScore > blackScore ? "white" : "black");

                int resultDifference = Math.Abs(whiteScore - blackScore);
                Console.WriteLine(resultDifference);
            }
        }
    }
}
