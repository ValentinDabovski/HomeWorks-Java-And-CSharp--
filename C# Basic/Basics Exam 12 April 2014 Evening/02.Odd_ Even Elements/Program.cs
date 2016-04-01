using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd__Even_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            List<double> evenNumbers = new List<double>();
            List<double> oddNumbers = new List<double>();

            double oddSum = 0;
            double oddMin = 0;
            double oddMax = 0;

            double evenSum = 0;
           
            for (int i = 0; i < input.Length; i++)
            {
                double number =  Convert.ToDouble(input[i]);

                if (number % 2 == 0)
                {
                    evenSum += number;
                    evenNumbers.Add(number);
                }

                else if (number % 2 != 0)
                {
                    oddSum += number;
                    oddNumbers.Add(number);
                }
            }
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",oddSum,oddNumbers.Min(),oddNumbers.Max(),evenSum,evenNumbers.Min(),evenNumbers.Max());
        }
    }
}
