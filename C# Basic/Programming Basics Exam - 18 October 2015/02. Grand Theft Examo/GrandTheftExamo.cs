using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Grand_Theft_Examo
{
    class GrandTheftExamo
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long thievesSlapped = 0;
            long thievesEscaped = 0;
            long sixPackBeer = 0;
            long bottleBeer = 0;
            long beerCosumed = 0;
            long thievesSlappedSum = 0;
            long thievesEscapedSum = 0;



            for (int i = 0; i < n; i++)
            {


                long thieves = long.Parse(Console.ReadLine());
                long beers = long.Parse(Console.ReadLine());

                //if (thieves =0)
                //{
                //    thievesEscapedSum = 0;
                //    thievesSlappedSum = 0;
                //}


                thievesEscaped = thieves - 5;

                if (thievesEscaped < 0)
                {
                    thievesSlapped = thieves;
                    thievesEscaped = 0;
                }
                else
                {
                    thievesSlapped = Math.Abs(thieves - thievesEscaped);
                }
       

                thievesSlappedSum += thievesSlapped;
                thievesEscapedSum += thievesEscaped;



                beerCosumed += beers;

                sixPackBeer = beerCosumed / 6;
                bottleBeer = beerCosumed % 6;
                // Console.WriteLine("{0}", beerCosumed / 6, beerCosumed % 6);



            }

            Console.WriteLine("{0} thieves slapped.", Math.Abs(thievesSlappedSum));
            Console.WriteLine("{0} thieves escaped.", Math.Abs(thievesEscapedSum));
            Console.WriteLine("{0} packs, {1} bottles.", (sixPackBeer), (bottleBeer));
        }
    }
}
