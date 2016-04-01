using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_5_Numbers
{
    class Sum5Numbers
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');

            double sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                double currentNumber = double.Parse(s[i]);
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
