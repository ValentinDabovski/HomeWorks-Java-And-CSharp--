using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Master_Herbalist
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyExpences = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            int hours = 0;
            string path = string.Empty;
            int price = 0;
            double moneyGained = 0;
            int herbsFound = 0;
            double moneyGainedSum = 0;
            int herbsFoundSum = 0;
            int days = 0;
            double totalMoney = 0;
            double averageEarnings = 0;
            double difference = 0;

            while (true)
            {
                if (input[0] == "Season")
                {

                    break;
                }

                hours = Convert.ToInt32(input[0]);
                path = input[1].ToUpper();
                price = Convert.ToInt32(input[2]);

                if (path.Length >= hours)
                {
                    for (int i = 0; i < (path.Length - hours) + 1; i++)
                    {
                        if (path[i] == 'H')
                        {
                            herbsFound++;
                            herbsFoundSum += herbsFound;
                            moneyGained = herbsFoundSum * price;
                            moneyGainedSum += moneyGained;

                        }
                    }
                }

                else if (path.Length <= hours)
                {
                    int PathPlus = hours - path.Length;
                    string PathCalc = Convert.ToString(path + path);
                    herbsFound = 0;
                    moneyGained = 0;

                    for (int i = 0; i < path.Length + PathPlus; i++)
                    {
                        if (PathCalc[i] == 'H')
                        {
                            herbsFound++;
                            moneyGained = herbsFound * price;

                        }
                    }
                }

                input = Console.ReadLine().Split(' ');
                days++;
            }

            totalMoney = moneyGained + moneyGainedSum;
            averageEarnings = totalMoney / days;
            difference = Math.Abs(averageEarnings - dailyExpences);

            if (dailyExpences <= averageEarnings)
            {
                Console.WriteLine("Times are good. Extra money per day: {0:F2}.", difference);
            }

            else if (dailyExpences >= averageEarnings)
            {
             //   Console.WriteLine("Times are in the red. Money needed: {0}"             
            }
        }
    }
}