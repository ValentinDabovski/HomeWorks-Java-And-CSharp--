using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Balanced_Parentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            Stack<char> openningParentheses = new Stack<char>();
            char[] closingParentheses = input.Substring(input.Length / 2, input.Length - (input.Length / 2)).ToCharArray();

            for (int i = 0; i < input.Length / 2; i++)
            {
                openningParentheses.Push(input[i]);
            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (openningParentheses.Peek().Equals(closingParentheses[i]))
                {
                    openningParentheses.Pop();
                }
            }


            if (openningParentheses.Count == 0)
            {
                Console.WriteLine("Yes");
            }

            else
            {

            }
        }
    }
}
