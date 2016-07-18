using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordor_s_Cruelty_Plan
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new[] {' ', ',', '!', '_', ';', '@',}, StringSplitOptions.RemoveEmptyEntries);

            var food = new FoodFactory();
            var mood = new MoodFactory();
            var gandalf = new Gandalf();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(food.GetFoodTypeAndPoints(input[i]));
                    
            }
            Console.WriteLine(food.HappinessPoints.Sum());
        }
    }
}