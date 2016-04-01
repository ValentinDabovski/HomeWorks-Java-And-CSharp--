using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Illuminati_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outterDots = n;
            int innerDots = n - 2;
            int sharp = n;
            int middleDots = 2;


            Console.WriteLine(new string('.',outterDots) + new string('#',sharp) + new string('.',outterDots));
            outterDots = n - 2;
            sharp = 3;
            innerDots = n - 2;

            Console.WriteLine(new string('.',outterDots) + new string('#',sharp) + new string('.',innerDots) + new string('#',sharp) + new string('.',outterDots));


            outterDots -= 2;

            for (int i = 0; i < n /2 -1; i++)
            {
                Console.WriteLine(new string('.',outterDots) + new string('#',2) + new string('.',middleDots) + new string('#',1) + new string('.',innerDots)  + new string('#',1) + new string('.',middleDots) + new string('#',2) + new string('.',outterDots));
                outterDots -= 2;
                middleDots += 2;
            }

            outterDots = 1;
            middleDots -= 2;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine(new string('.', outterDots) + new string('#', 2) + new string('.', middleDots) + new string('#', 1) + new string('.', innerDots) + new string('#', 1) + new string('.', middleDots) + new string('#', 2) + new string('.', outterDots));
                outterDots += 2;
                middleDots -= 2; 
            }

            Console.WriteLine(new string('.', n-2) + new string('#', 3) + new string('.', n-2) + new string('#', 3) + new string('.', n-2));


            Console.WriteLine(new string('.', n) + new string('#', n) + new string('.', n));
        }
    }
}
