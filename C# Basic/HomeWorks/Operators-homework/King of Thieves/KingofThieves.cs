using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kingOfThieves
{
    class kingOfThieves
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char s = char.Parse(Console.ReadLine());

            int dashCount = (n - 1) / 2;
            int sCount = 1;

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.Write(new string('-', dashCount));
                Console.Write(new string(s, sCount));
                Console.Write(new string('-', dashCount));

                Console.WriteLine();

                dashCount--;
                sCount += 2;

            }

            Console.Write(new string(s, n));
            Console.WriteLine();

            dashCount++;
            sCount -= 2;

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.Write(new string('-', dashCount));
                Console.Write(new string(s, sCount));
                Console.Write(new string('-', dashCount));
                Console.WriteLine();

                dashCount++;
                sCount -= 2;
            }


        }
    }
}
