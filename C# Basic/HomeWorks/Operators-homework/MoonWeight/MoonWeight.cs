using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonWeight
{
    class MoonWeight
    {
        static void Main()
        {
            Console.WriteLine("Type your weight: ");
            double a = double.Parse(Console.ReadLine());
            double moonweight = a * (double)17 / 100;
            Console.WriteLine("Your MoonWeight is: {0}", moonweight);



        }
    }
}
