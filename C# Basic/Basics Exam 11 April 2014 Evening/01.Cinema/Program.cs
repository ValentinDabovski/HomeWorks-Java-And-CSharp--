using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieFormat = Console.ReadLine();
            decimal rows = decimal.Parse(Console.ReadLine());
            decimal columns = decimal.Parse(Console.ReadLine());

            decimal premiere = 12.00m;
            decimal normal = 7.50m;
            decimal discount = 5.00m;
            decimal budget = 0;

            switch (movieFormat)
            {
                case "Premiere":

                    budget = (rows * columns) * premiere;
                    Console.WriteLine("{0} leva",Math.Round(budget,2));
                    break;

                case "Normal":
                    budget = (rows * columns) * normal;
                    Console.WriteLine("{0} leva",Math.Round(budget,2));
                    break;

                case "Discount":
                    budget = (rows * columns) * discount;
                    Console.WriteLine("{0} leva", Math.Round(budget,2));
                    break;
            }
        }
    }
}
