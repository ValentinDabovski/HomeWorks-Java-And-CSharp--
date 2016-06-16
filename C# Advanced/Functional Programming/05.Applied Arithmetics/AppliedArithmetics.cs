using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;


namespace _05.Applied_Arithmetics
{
    public class AppliedArithmetics
    {
        public static void Main(string[] args)
        {
            int[] numbersFromInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            string commands = Console.ReadLine();

            while (!commands.Equals("end"))
            {
                commands = Console.ReadLine();

                DoArithmetics(numbersFromInput, commands);
            }
        }


        public static List<int> DoArithmetics(int[] numbersFromInput, string command)
        {
            List<int> numbers = new List<int>();

            switch (command)
            {
                case "add":
                    for (int i = 0; i < numbersFromInput.Length; i++)
                    {
                        numbersFromInput[i] += numbersFromInput[i] + 1;
                    }
                    break;

                case "multiply":
                    for (int i = 0; i < numbersFromInput.Length; i++)
                    {
                        numbersFromInput[i] += numbersFromInput[i]*2;
                    }
                    break;

                case "subtract":
                    for (int i = 0; i < numbersFromInput.Length; i++)
                    {
                        numbersFromInput[i] += numbersFromInput[i] - 1;
                    }
                    break;

                case "print":
                    foreach (var number in numbersFromInput)
                    {
                        Console.Write(number + " ");
                    }
                    break;
            }

            return numbers;
        }

    }
}
