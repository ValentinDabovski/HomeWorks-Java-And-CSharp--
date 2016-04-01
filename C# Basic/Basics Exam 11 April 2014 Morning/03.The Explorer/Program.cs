using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.The_Explorer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int middleLine = 1;
            int asteriks = 1;
            int outLine = n/2 - 1;

            Console.WriteLine(new string('-',n/2) + new string('*',1) + new string('-',n/2));
            
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine(new string('-', outLine) + new string('*', asteriks) + new string('-', middleLine) + new string('*', asteriks) + new string('-', outLine));
                middleLine += 2;
                outLine--;
            }

            Console.WriteLine(new string('*',1) + new string('-',n-2) + new string('*',1));

            middleLine -= 2;
             outLine ++;

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine(new string('-', outLine) + new string('*', 1) + new string('-', middleLine) + new string('*', 1) + new string('-', outLine));
                outLine++;
                middleLine -= 2;                
               
            }


            Console.WriteLine(new string('-', n / 2) + new string('*', 1) + new string('-', n / 2));

        }
    }
}
