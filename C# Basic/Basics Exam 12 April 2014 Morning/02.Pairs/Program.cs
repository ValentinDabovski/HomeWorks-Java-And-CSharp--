using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int pair = 0;

            for (int i = 0; i < numbers.Length; )
            {
                pair = numbers[i] + numbers[i+1];
                i += 2;
            }

        }
    }
}
