using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice001
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal FG = decimal.Parse(Console.ReadLine());
            decimal FGA = decimal.Parse(Console.ReadLine());
            decimal threePoints = decimal.Parse(Console.ReadLine());
            decimal TOV = decimal.Parse(Console.ReadLine());
            decimal ORB = decimal.Parse(Console.ReadLine());
            decimal OppDRB = decimal.Parse(Console.ReadLine());
            decimal FT = decimal.Parse(Console.ReadLine());
            decimal FTA = decimal.Parse(Console.ReadLine());

            decimal eFGPercentage = decimal.MinValue;
            decimal TOVPercentage = decimal.MinValue;
            decimal ORBPercentage = decimal.MinValue;
            decimal FTPercentage = decimal.MinValue;

            eFGPercentage = (FG + 0.5m * threePoints) / FGA;

            TOVPercentage = (TOV / (FGA + 0.44m * FTA + TOV));

            ORBPercentage = ORB / (ORB + OppDRB);

            FTPercentage = FT / FGA;

            Console.WriteLine("eFG% {0}", Math.Round(eFGPercentage, 3));
            Console.WriteLine("TOV% {0}", Math.Round(TOVPercentage, 3));
            Console.WriteLine("ORB% {0}", Math.Round(ORBPercentage, 3));
            Console.WriteLine("FT% {0}", Math.Round(FTPercentage, 3));



        }
    }
}