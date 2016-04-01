using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find7
{
    class Seven
    {
        static void Main()
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            int numfind = (num / 100) % 10;
            bool seven = numfind == 7;
            Console.WriteLine("third digit " + seven);
        }
    }
}

