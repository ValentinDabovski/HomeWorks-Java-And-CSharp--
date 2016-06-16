using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class reverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reversedInput = new Stack<char>();
            input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
               reversedInput.Push(input[i]);
            }

            char[] reversedString = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                reversedString[i] = reversedInput.Pop();
            }

            Console.WriteLine(string.Join("", reversedString));
        }
    }
}
