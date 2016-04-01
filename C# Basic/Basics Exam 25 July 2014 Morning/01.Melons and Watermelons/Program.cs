using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Melons_and_Watermelons
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDayInWeek = int.Parse(Console.ReadLine());
            numberOfDayInWeek -= 1;
            int sequentialDays = int.Parse(Console.ReadLine());
            int watermelons = 0;
            int melons = 0;
            int SumOfDays = numberOfDayInWeek + sequentialDays;
            int result = 0;

            for (int i = numberOfDayInWeek; i < SumOfDays; i++)
            {

                switch (  i % 7 )
                {
                    case 0:
                        watermelons += 1;
                        

                        break;

                    case 1:
                        melons += 2;

                        break;

                    case 2:
                        watermelons += 1;
                        melons += 1;

                        break;

                    case 3:
                        watermelons += 2;
                        
                        break;

                    case 4:
                        watermelons += 2;
                        melons += 2;
                        break;

                    case 5:
                        watermelons += 1;
                        melons += 2;
                        break;

                    case 6:
                        watermelons += 0;
                        melons += 0;
                        break;

                }


            }
            if (watermelons == melons)
            {
                Console.WriteLine("Equal amount: {0}",watermelons);
            }

            else if (watermelons > melons)
            {
                result = watermelons - melons;
                Console.WriteLine("{0} more watermelons",result);
            }

            else if (melons > watermelons)
            {
                result = melons - watermelons;
                Console.WriteLine("{0} more melons",result);
            }
        }
    }
}
