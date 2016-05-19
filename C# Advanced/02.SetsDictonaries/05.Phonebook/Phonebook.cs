using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var phonebookDict = new Dictionary<string, string>();

            while (!input.Equals("search"))
            {
                string[] splitedInput = input.Split('-');

                if (!phonebookDict.ContainsKey(splitedInput[0]))
                {
                    phonebookDict.Add(splitedInput[0], splitedInput[1]);
                }

                phonebookDict[splitedInput[0]] = splitedInput[1];

                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while (!input.Equals("stop"))
            {
                if (!phonebookDict.ContainsKey(input))
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }

                else
                {
                    Console.WriteLine($"{input} -> {phonebookDict[input]}");
                }

                input = Console.ReadLine();
            }
        }
    }
}
