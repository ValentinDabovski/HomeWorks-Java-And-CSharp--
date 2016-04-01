using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outterDots = n / 2;
            int innerDots = n -2;


            Console.WriteLine(new string('.',n/2) + new string('#',n) + new string('.',n/2));

            for (int i = 0; i < n -2; i++)
            {
                Console.WriteLine(new string('.',outterDots) + new string('#',1) + new string('.',innerDots) +  new string('#',1) + new string('.',outterDots));
            }

            Console.WriteLine(new  string('#',n/2+1) + new string('.',n-2) + new string('#',n/2+1));
            outterDots = 1;
            innerDots = ((n - 2) * 2 )- 1;

            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine(new string('.',outterDots) + new string('#',1) + new string('.',innerDots) + new string('#',1) + new string('.',outterDots));

                innerDots -= 2;
                outterDots +=1 ;

            }
            Console.WriteLine(new string('.',n-1) + new string('#',1) + new string('.',n-1));
        }
    }
}
