using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Number_from_One_to_N
{
    class OneToN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int  i = 1;  i <= n;  i++)
            {
                Console.WriteLine();
                Console.Write(i);
                Console.WriteLine();
                
            }
        }
    }
}
