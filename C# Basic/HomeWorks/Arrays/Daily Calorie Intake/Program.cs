using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Calorie_Intake
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal weight = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());
            decimal age = decimal.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            decimal workoutPerWeek = decimal.Parse(Console.ReadLine());

            decimal weightKg = ( weight / 2.2m);
            decimal heightCm = (height * 2.54m);

            decimal DCI = 0;

            decimal menBMR = 66.5m + (13.75m * weightKg) + (5.003m * heightCm) - (6.755m * age);
            decimal womenBMR = 655m + (9.563m * weightKg) + (1.850m * heightCm) - (4.676m * age);


            if (gender.Equals("m"))
            {
                if (workoutPerWeek <= 0)
                {
                    DCI = menBMR * 1.2m;
                }

                else if (workoutPerWeek >= 1 && workoutPerWeek <= 3 )
                {
                    DCI = menBMR * 1.375m;
                }

                else if (workoutPerWeek >= 4 && workoutPerWeek <= 6)
                {
                    DCI = menBMR * 1.55m;
                }

                else if (workoutPerWeek >= 7 && workoutPerWeek <=9)
                {
                    DCI = menBMR * 1.725m;
                }

                else if (workoutPerWeek > 9)
                {
                    DCI = menBMR * 1.9m;
                }
            }


            else if (gender.Equals("f"))
            {
                if (workoutPerWeek <= 0)
                {
                    DCI = menBMR * 1.2m;
                }

                else if (workoutPerWeek >= 1 && workoutPerWeek <= 3)
                {
                    DCI = menBMR * 1.375m;
                }

                else if (workoutPerWeek >= 4 && workoutPerWeek <= 6)
                {
                    DCI = menBMR * 1.55m;
                }

                else if (workoutPerWeek >= 7 && workoutPerWeek <= 9)
                {
                    DCI = menBMR * 1.725m;
                }

                else if (workoutPerWeek > 9)
                {
                    DCI = menBMR * 1.9m;
                }
            }
            Console.WriteLine(Math.Round(DCI));
        }
    }
}
