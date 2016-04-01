using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Min__Max__Sum_and_Average_of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            int min = numbers[0];
            int max = numbers[0];

            for (int i = 0; i < n; i++)

            {
                if (min > numbers[i])
                {
                    min = numbers[i];

                }

                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("min={0}", min);
            Console.WriteLine("max={0}", max);
            Console.WriteLine("sum={0}", sum);
            Console.WriteLine("average={0:F2}", (double)sum / n);
        } 

    }
}
