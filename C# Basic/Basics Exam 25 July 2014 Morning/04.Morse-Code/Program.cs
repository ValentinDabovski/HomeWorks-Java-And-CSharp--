using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Morse_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = n.ToString();

            input.ToCharArray();

            int sum = 0;
            int secondSum = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsNumber(input[i]))
                {
                    sum += input[i];
                    sum -= 48;
                    secondSum = sum;

                    
                }
                
            }
            
            Console.WriteLine(sum);
            Console.WriteLine(secondSum);
            

        }
    }
}
