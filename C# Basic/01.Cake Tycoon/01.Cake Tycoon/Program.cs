using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cake_Tycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong wantedCakes = ulong.Parse(Console.ReadLine());
            double amountFlour = double.Parse(Console.ReadLine());
            double flourAvailable = double.Parse(Console.ReadLine());
            double amountOfTrufels = double.Parse(Console.ReadLine());
            double priceOfOneTrufel = double.Parse(Console.ReadLine());

            double cakesMake =  Math.Floor(flourAvailable / amountFlour);
            double trufflesCost = amountOfTrufels * priceOfOneTrufel;
            double cakePrice = ( (trufflesCost / wantedCakes) * 1.25);

            double flourRequired = (wantedCakes * amountFlour);

            if (cakesMake >= wantedCakes)
            {
                Console.WriteLine("All products available, price of a cake: {0:F2}",cakePrice);
            }


            else if (cakesMake <= wantedCakes)
            {
                Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", cakesMake, flourRequired - flourAvailable);
            }
        }
    }
}
