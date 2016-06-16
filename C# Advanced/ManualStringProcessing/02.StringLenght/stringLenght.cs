using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringLenght
{
    class stringLenght
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input.ToCharArray();
            int charCounter = input.ToCharArray().Length;
            const int maxChars = 20;
            char charToImplement = '*';

            if (maxChars > charCounter)
            {
                Console.Write(input);
                Console.Write(new string(charToImplement, maxChars - charCounter));
                Console.WriteLine();
            }

            else if (maxChars <  charCounter)
            {
                Console.WriteLine(input.Substring(0, maxChars)); 
            }
        }
    }
}

