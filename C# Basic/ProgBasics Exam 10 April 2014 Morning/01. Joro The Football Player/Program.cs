using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Joro_The_Football_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearFormat = Console.ReadLine();
            double numberHolidays = int.Parse(Console.ReadLine());
            double weekendInHometown = int.Parse(Console.ReadLine());
            double result = 0;
            double games = 0;

            double normalWeekends = 52 - weekendInHometown;
            games = normalWeekends * 2 / 3;
            games += numberHolidays / 2;
            games += weekendInHometown;
            if (yearFormat == "t")
            {
                games += 3;
            }

            Console.WriteLine(Math.Floor(games));
        }
    }
}
