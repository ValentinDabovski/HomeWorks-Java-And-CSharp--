using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Baba_Tinche_Airlines
{
    class BabaTinche
    {
        static void Main()
        {

            string[] pasengersFirstClass = Console.ReadLine().Split();
            string[] pasengersBusinessClass = Console.ReadLine().Split();
            string[] pasengersEconomyClass = Console.ReadLine().Split();

            int allPassengerFirstClass = Convert.ToInt32(pasengersFirstClass[0]);
            int FrequentFirstClass = Convert.ToInt32(pasengersFirstClass[1]);
            int mealsFirstClass = Convert.ToInt32(pasengersFirstClass[2]);

            int allPassengerBusinessClass = Convert.ToInt32(pasengersBusinessClass[0]);
            int FrequentBusinessClass = Convert.ToInt32(pasengersBusinessClass[1]);
            int mealsBusinessClass = Convert.ToInt32(pasengersBusinessClass[2]);


            int allPassengerEconomyClass = Convert.ToInt32(pasengersEconomyClass[0]);
            int FrequentEconomyClass = Convert.ToInt32(pasengersEconomyClass[1]);
            int mealsEconomyClass = Convert.ToInt32(pasengersEconomyClass[2]);



            int firstClassProfit = ((allPassengerFirstClass - FrequentFirstClass) * 7000) + (int)(FrequentFirstClass * (7000 * 0.3)) + (int)(mealsFirstClass * (7000 * 0.005));

            int businessClassProfit = ((allPassengerBusinessClass - FrequentBusinessClass) * 3500) + (int)(FrequentBusinessClass * (3500 * 0.3)) + (int)(mealsBusinessClass * (3500 * 0.005));

            int economyClassProfit = (((allPassengerEconomyClass - FrequentEconomyClass) * 1000) + (int)(FrequentEconomyClass * (1000 * 0.3)) + (int)(mealsEconomyClass * (1000 * 0.005)));


            int profit = firstClassProfit + businessClassProfit + economyClassProfit;
           



            int maxprofit = ((12 * 7000) + (int)(12 * (7000 * 0.005))) + ((28 * 3500) + (int)(28 * (3500 * 0.005))) + ((50 * 1000) + (int)(50 * (1000 * 0.005)));


            int differnce = maxprofit - profit;

            Console.WriteLine();

            Console.WriteLine(profit);
            Console.WriteLine(differnce);

        }
    }
}

