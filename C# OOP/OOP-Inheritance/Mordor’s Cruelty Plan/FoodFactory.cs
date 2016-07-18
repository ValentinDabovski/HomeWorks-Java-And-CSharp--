using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordor_s_Cruelty_Plan
{
    public class FoodFactory 
    {

        public FoodFactory()
        {

        }

        public string FoodType { get; set; }
        public List<int> HappinessPoints { get; set; } = new List<int>();

        public string GetFoodTypeAndPoints(string food)
        {
        

            switch (food.ToLower())
            {
                case "cram":
                    FoodType = "Cram";
                    HappinessPoints.Add(2);
                    break;

                case "lembas":
                    FoodType = "Lembas";
                    HappinessPoints.Add(3);
                    break;

                case "apple":
                    FoodType = "Apple";
                    HappinessPoints.Add(1);
                    break;

                case "melon":
                    FoodType = "Melon";
                    HappinessPoints.Add(1);
                    break;

                case "honeycake":
                    FoodType = "HoneyCake";
                    HappinessPoints.Add(5);
                    break;

                case "mushrooms":
                    FoodType = "Mushrooms";
                    HappinessPoints.Add(-10);
                    break;

                default:
                    HappinessPoints.Add(-1);
                    break;
            }

            return FoodType;
        }

    }
}
