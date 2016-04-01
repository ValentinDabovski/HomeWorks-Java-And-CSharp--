using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wine_Glass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outterDots = 1;
            int asteriks = n - 2;
            int glass = 1;
            int rowCount = 0;
            int rowCountSum = 0;
            int dashes = 0;

            Console.WriteLine(new string('\\', glass) + new string('*', asteriks) + new string('/', glass));

            if (n >= 12)
            {

                for (int i = 0; i < n / 2 - 1; i++)
                {

                    asteriks -= 2;
                    Console.WriteLine(new string('.', outterDots) + new string('\\', glass) + new string('*', asteriks) + new string('/', glass) + new string('.', outterDots));
                    outterDots++;
                    rowCount++;
                    rowCountSum += rowCount;


                }
                outterDots = n / 2 - 1;

                // Console.WriteLine(new string('.', outterDots) + new string('\\',glass) + new string('/',glass) + new string('.',outterDots));

                for (int i = 0; i < n / 2 - 2; i++)
                {

                    Console.WriteLine(new string('.', outterDots) + new string('|', glass) + new string('|', glass) + new string('.', outterDots));
                    rowCount++;

                }
                rowCountSum += rowCount;

                dashes = (Math.Abs(rowCount - n));

                for (int i = 1; i < dashes; i++)
                {
                    Console.WriteLine(new string('-', n));
                }


            }



            else
            {
                for (int i = 0; i < n / 2 - 2; i++)
                {

                    asteriks -= 2;
                    Console.WriteLine(new string('.', outterDots) + new string('\\', glass) + new string('*', asteriks) + new string('/', glass) + new string('.', outterDots));
                    outterDots++;
                    rowCount++;
                    rowCountSum += rowCount;

                }
                outterDots = n / 2 - 1;

                Console.WriteLine(new string('.', outterDots) + new string('\\', glass) + new string('/', glass) + new string('.', outterDots));
                rowCount++;

                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine(new string('.', outterDots) + new string('|', glass) + new string('|', glass) + new string('.', outterDots));
                    rowCount++;
                }

                rowCountSum += rowCount;

                dashes = (Math.Abs(n - rowCountSum));

                for (int i = 0; i < dashes; i++)
                {
                    Console.WriteLine(new string('-', n));
                }
            }

        }
    }
}
