using System;
using System.ComponentModel;

namespace _03.CustomMinFunction
{

    public static class MyClass
    {
        public static int MinNumber(this int[] inputInts, Func<int, int, bool> Min)
        {
            int min = inputInts[0];
            for (int i = 0; i < inputInts.Length; i++)
            {
                if (Min(inputInts[i], min))
                {
                    min = inputInts[i];
                }
            }
            return min;
        }
    }

    public class CustomMinFunction
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] numbersInts = NumbersFromInput(input);
            Console.WriteLine(numbersInts.MinNumber((x, y) => x < y));
        }

        public static int[] NumbersFromInput(string[] input)
        {
            int[] numberFromInput = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {

                numberFromInput[i] = Convert.ToInt32(input[i]);
            }
            return numberFromInput;
        }
    }
}

