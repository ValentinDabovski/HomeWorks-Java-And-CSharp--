using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sum_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');           
            double sumNumbers = 0;
            double sum = 0;
            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }


            for (int i = 0; i < input.Length; i++)
            {

                double number = Convert.ToDouble(input[i]);
                sumNumbers += number;
            }
           
            int maxNumber = numbers.Max();

            sum = sumNumbers - maxNumber;

          

            if (sum == maxNumber)
            {
                Console.WriteLine("Yes, sum={0}", sum);
            }

            else 
            {
                Console.WriteLine("No, diff={0}", Math.Abs(sum - maxNumber));
            }

        }
    }
}
