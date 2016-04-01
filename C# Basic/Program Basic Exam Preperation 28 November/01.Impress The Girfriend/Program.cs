using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Impress_The_Girfriend
{
    class Program
    {
        static void Main(string[] args)
        {
            uint amountRubles = uint.Parse(Console.ReadLine());
            uint amountDollars = uint.Parse(Console.ReadLine());
            uint amountEuro = uint.Parse(Console.ReadLine());
            uint siteB = uint.Parse(Console.ReadLine()); // leva
            uint siteM = uint.Parse(Console.ReadLine()); // leva 

            decimal rublesToLeva = (amountRubles / 100m ) * 3.5m;
            decimal dollarsToLeva = amountDollars * 1.5m;
            decimal euroToLeva = amountEuro * 1.95m;
            siteB /= 2;


            decimal[] prices = { rublesToLeva, dollarsToLeva, euroToLeva, siteB ,siteM };

            decimal finalPrise = prices.Max();
            
          
            Console.WriteLine("{0:F2}", Math.Ceiling(finalPrise));

 
        }
    }
}
