using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outterDots = 0;
            int innerDots = 0;
            int assteriks = 0;
            
            Console.WriteLine(new string( '.',n/2) + new string('*',1) + new string('.',n/2));

            innerDots = 1;
            outterDots = n / 2 - 1;

            for (int i = 0; i < n/2-1; i++)
            {
                Console.WriteLine(new string('.', outterDots) + new string('*', 1) + new string('.',innerDots) + new string('*',1) + new string('.', outterDots));
                outterDots--;
                innerDots += 2;
            }

            Console.WriteLine(new string('*',n));

            outterDots = n / 4;
            innerDots = (n / 2 - 1) + 1;

            for (int i = 0; i < n/ 2 -1; i++)
            {
                Console.WriteLine(new string('.',outterDots) + new string('*',1) + new string('.',innerDots) + new string('*',1) + new string('.',outterDots));

                
            }



            Console.WriteLine(new string('.', outterDots) + new string('*',n - (outterDots + outterDots)) + new string('.',outterDots));
        }
    }
}
