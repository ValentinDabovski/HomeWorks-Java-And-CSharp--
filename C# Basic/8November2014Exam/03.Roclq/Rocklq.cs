using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Roclq
{
    class Rocklq
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.',n) + new string('*',n) + new string('.',n));

            int outterDots = n - 2;
            int innerDots = n + 2;
            

            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine(new string('.',outterDots) + '*' + new string('.',innerDots) + '*' + new string('.',outterDots));
                outterDots-=2;
                innerDots+=4;
            }

            Console.WriteLine('*' + new string('.', n-2) + '*' + new string('.',n) + '*' + new string('.' ,n-2) + '*');

            outterDots = n - 4;
            innerDots = 1;
            for (int i = 0; i < n/2 - 1; i++)
            {
                Console.WriteLine('*' + new string('.', outterDots) + '*' + new string('.',innerDots) + '*' + new string('.',n) + '*' + new string('.',innerDots) + '*' + new string('.',outterDots)   + '*');


                outterDots -= 2;
                innerDots += 2;
            }

            outterDots = n-1;
            innerDots = n;

            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    Console.WriteLine(new string('*',n*3));
                }


                else
                {
                    Console.WriteLine(new string('.', outterDots) + '*' + new string('.', innerDots) + '*' + new string('.',outterDots));

                    outterDots--;
                    innerDots+=2;



                }



            }

        }
    }
}
