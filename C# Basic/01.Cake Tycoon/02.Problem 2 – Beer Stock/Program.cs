using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem_2___Beer_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            double reservedBeers = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split(' ');

            double cases = 0;
            double casesSum = 0;

            double sixpack = 0;
            double sixpackSum = 0;

            double beers = 0;
            double beersSum = 0;

            double amountOfbeer = 0;

            double beerNeeded = 0;
            double beersLeftFromCase = 0;
            double beersLeftFromSixpack = 0;

            double beersLeft = 0;


            while (true)
            {
                if (command[0].ToLower() == "exam")
                {
                    break;
                }

                int beerNumber = Convert.ToInt32(command[0]);



                switch (command[1])
                {
                    case "beers":
                        beers = beerNumber;
                        beersSum += beers;
                        break;

                    case "cases":
                        cases = beerNumber;
                        casesSum += cases;
                        break;

                    case "sixpacks":
                        sixpack = beerNumber;
                        sixpackSum += sixpack;
                        break;
                }

                command = Console.ReadLine().Split(' ');
            }

            amountOfbeer = (casesSum * 24) + (sixpackSum * 6) + beersSum;

            beerNeeded = reservedBeers - amountOfbeer;

            if (amountOfbeer >= 100)
            {
                Math.Round(beers = amountOfbeer / 100);
                amountOfbeer = Math.Round(amountOfbeer - beers);
            }


            if (amountOfbeer <= reservedBeers)
            {
                beersLeft = Math.Abs(amountOfbeer - reservedBeers);
                cases = Math.Floor(beersLeft / 24);
                beersLeftFromCase = beersLeft - (cases * 24);
                sixpack = Math.Floor(beersLeftFromCase / 6);
                beersLeftFromSixpack = (beersLeftFromCase % 6);

                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", cases, sixpack, beersLeftFromSixpack);


            }

            if (amountOfbeer >= reservedBeers)
            {
                beersLeft = amountOfbeer - reservedBeers;
                cases = Math.Floor(beersLeft / 24);
                beersLeftFromCase = beersLeft - (cases * 24);
                sixpack = Math.Round(beersLeftFromCase / 6);
                beersLeftFromSixpack = beersLeftFromCase % 6;

                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", cases, sixpack, beersLeftFromSixpack);
            }
        }
    }
}
