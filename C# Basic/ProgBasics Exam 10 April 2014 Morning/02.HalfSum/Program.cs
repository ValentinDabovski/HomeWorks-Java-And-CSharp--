using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HalfSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numbers = 0;
            int firstNumbers = 0;
            int secondNumbers = 0;
   
            for (int i = 1; i <= n * 2; i++)
            {
                numbers = int.Parse(Console.ReadLine());
                if (i <= n)
                { 
                    firstNumbers += numbers;   
                }
                else
                {  
                    secondNumbers += numbers;
                }

            }
            
            if (firstNumbers == secondNumbers)
            {
                Console.WriteLine("Yes, sum={0}",firstNumbers);
            }

            else 
            {
                Console.WriteLine("No, diff={0}",Math.Abs(firstNumbers-secondNumbers));
            }

        }
    }
}
