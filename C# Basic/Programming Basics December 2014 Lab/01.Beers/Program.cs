using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Beers
{
    class Program
    {
        static void Main(string[] args)
        {
            int stacks = 0;
            int beers = 0;
            int stackSum = 0;
            int beersSum = 0;

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input[0] == "End")
                {
                    break;
                }

                int numberBeers = Convert.ToInt32(input[0]);
                string beerMeasure = input[1];

                for (int i = 1; i < input.Length; i++)
                {
                    if (beerMeasure == "stacks")
                    {
                        beers = numberBeers;
                        beers %= 20;
                        beersSum += beers;
                    }
                    else if (beerMeasure == "beers")
                    {
                        stacks = numberBeers;
                        stacks /= 20;
                        stackSum += stacks;
                    }



                }
            }


            Console.WriteLine(stackSum);
            Console.WriteLine(beersSum);
        }

    }
}
