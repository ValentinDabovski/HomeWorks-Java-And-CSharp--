using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace _04.FindEvensOrOdds
{
    public class FindEvensOrOdds
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            string command = Console.ReadLine();
            List<int> numbers = new List<int>();

            NumbersInList(input, command).ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
        }

        public static List<int> NumbersInList(string[] input, string command)
        {
            int startFrom = Convert.ToInt32(input[0]);
            int end = Convert.ToInt32(input[1]);
            List<int> numbers = new List<int>();


            switch (command)
            {
                case "odd":
                    for (int i = startFrom; i <= end; i++)
                    {
                        if (i % 2 != 0)
                        {
                            numbers.Add(i);
                        }
                    }

                    break;

                case "even":
                    for (int i = startFrom; i <= end; i++)
                    {
                        if (i % 2 == 0)
                        {
                            numbers.Add(i);
                        }
                    }
                    break;
            }

            return numbers;
        }
    }
}