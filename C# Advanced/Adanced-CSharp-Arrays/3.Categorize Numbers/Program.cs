using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Categorize_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<double> floatingPointNumbers = new List<double>();
            List<double> nonFloatingPointNumbers = new List<double>();

            for (int i = 0; i < input.Length; i++)
            {

                var number = Convert.ToDouble(input[i]);
                

                if (number % 1 == 0)
                {
                    nonFloatingPointNumbers.Add(Convert.ToDouble(number));
                }

                else
                {
                    floatingPointNumbers.Add(Convert.ToDouble(number));

                }
            }       
        }
    } 
}
