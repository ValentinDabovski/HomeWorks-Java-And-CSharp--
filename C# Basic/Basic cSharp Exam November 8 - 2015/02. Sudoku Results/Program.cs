using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sudoku_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            double timeMinutes = 0;
            double timeSeconds = 0;
            double timeSum = 0;
            double games = 0;
            double Sum = 0;
            while (true)
            {
                string[] inputTime = Console.ReadLine().Split(':');
                if (inputTime[0] == "Quit")
                {
                    break;
                }

                 timeMinutes = Convert.ToInt32(inputTime[0]);
                 timeSeconds = Convert.ToInt32(inputTime[1]);

                timeSum = (timeMinutes * 60) + (timeSeconds);
                Sum += timeSum;

                games++;
            }
            double gameResult = Sum / games;
           
            if (gameResult < 720 )
            {
                Console.WriteLine("Gold Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}",games,Math.Ceiling(gameResult));
            }

            else if (gameResult >= 720 && gameResult <= 1440)
            {
                Console.WriteLine("Silver Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}",games,Math.Ceiling(gameResult));
            }


            else
            {
                Console.WriteLine("Bronze Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}",games, Math.Ceiling(gameResult));
            }
             
        }
    }
}
