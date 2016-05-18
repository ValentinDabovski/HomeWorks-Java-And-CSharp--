using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Sequences_of_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<string> inputCopy = new List<string> { };
            string copyWord = string.Empty;
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {               
                for (int j = i; j < (input.Length - 1); j++)
                {
                    if (input[j] == input[j + 1])
                    {
                        copyWord = input[j];
                        inputCopy.Add(copyWord);
                        count++;
                    }                    
                }             
            }

            foreach (var word in inputCopy)
            {
                Console.WriteLine(word);
            }                
        }
    }
}
