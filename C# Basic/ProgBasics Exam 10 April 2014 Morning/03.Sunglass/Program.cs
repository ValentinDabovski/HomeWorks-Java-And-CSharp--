using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sunglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*',n*2));
            

            for (int i = 0; i < n/ 2  -1 ; i++)
            {
                Console.WriteLine(new string('*', 1) + new string('/', (n * 2) - 2) + new string('*', 1) + new string(' ', n) + (new string('*', 1) + new string('/', (n * 2) - 2) + new string('*', 1)));
            }

            Console.WriteLine(new string('*', 1) + new string('/', (n * 2) - 2) + new string('*', 1) + new string('|', n) + (new string('*', 1) + new string('/', (n * 2) - 2) + new string('*', 1)));

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine(new string('*', 1) + new string('/', (n * 2) - 2) + new string('*', 1) + new string(' ', n) + (new string('*', 1) + new string('/', (n * 2) - 2) + new string('*', 1)));
            }

            Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));
            
        }
    }
}
