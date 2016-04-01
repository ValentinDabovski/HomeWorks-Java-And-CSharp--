using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ArrayMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');

            string firstArr = input[0];
            string secondArr = input[1];
            string command = input[2];

            List<char> resultArr = new List<char>();

            if (input.Last() == "join") 
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (secondArr.Contains(firstArr[i]))
                    {
                        resultArr.Add(firstArr[i]);
                    }
                }
            }

            else if (input.Last() == "right exclude")
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (!secondArr.Contains(firstArr[i]))
                    {
                        resultArr.Add(firstArr[i]);
                    }
                }
            }

            else
            {
                for (int i = 0; i < secondArr.Length; i++)
                {
                    if (!firstArr.Contains(secondArr[i]))
                    {
                        resultArr.Add(secondArr[i]);
                    }
                }
            }

            resultArr.Sort();

            foreach (var arr in resultArr)
            {
                Console.Write(arr);
            }
        }
    }
}
