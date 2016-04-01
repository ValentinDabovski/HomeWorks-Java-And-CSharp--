using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dash = n/2 -1;
            int asteriks = 3;
            int pipe = 1;

            Console.WriteLine(new string('-',n/2) + new string('*',1) + new string('-',n/2));

            for (int i = 0; i < n /2 -1; i++)
            {
                Console.WriteLine(new string('-',dash) + new string('*',asteriks) + new string('-',dash));
                dash--;
                asteriks += 2;
            }

            Console.WriteLine(new string('*',n));


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('|', pipe) + new string('*',n-2) + new string('|',pipe));
            }

        }
    }
}
