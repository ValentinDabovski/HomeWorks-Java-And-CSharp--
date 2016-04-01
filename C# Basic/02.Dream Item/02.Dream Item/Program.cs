using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dream_Item
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            string month = input[0];
            decimal moneyPerHour = decimal.Parse(input[1]);
            decimal hoursPerDay = decimal.Parse(input[2]);
            decimal priceOfItem = decimal.Parse(input[3]);
            int inputMonth = 0;
            decimal MoneyInMonth = 0;
            decimal bonus = 0;

            int Jan = 21;
            int Feb = 18;
            int March = 21;
            int Apr = 20;
            int May = 20;
            int June = 20;
            int July = 21;
            int Aug = 21;
            int Sept = 20;
            int Oct = 21;
            int Nov = 20;
            int Dec = 21;
            
            switch (input[0])
            {
                case "Jan":
                    inputMonth = Jan;
                    MoneyInMonth = moneyPerHour * hoursPerDay * Jan;
                    break;

                case "Feb":
                    inputMonth = Feb;
                    MoneyInMonth = moneyPerHour * hoursPerDay * Feb;
                    break;
                case "March":
                    inputMonth = March;
                    MoneyInMonth = moneyPerHour * hoursPerDay * March;
                    break;
                case "Apr":
                    inputMonth = Apr;
                    MoneyInMonth = moneyPerHour * hoursPerDay * Apr;
                    break;
                case "May":
                    inputMonth = May;
                    MoneyInMonth = moneyPerHour * hoursPerDay * May;
                    break;
                case "June":
                    inputMonth = June;
                    MoneyInMonth = moneyPerHour * hoursPerDay * June;
                    break;
                case "July":
                    inputMonth = July;
                    MoneyInMonth = moneyPerHour * hoursPerDay * July;
                    break;
                case "Aug":
                    inputMonth = Aug;
                    MoneyInMonth = moneyPerHour * hoursPerDay * Aug;
                    break;
                case "Sept":
                    inputMonth = Sept;
                    MoneyInMonth = moneyPerHour * hoursPerDay * Sept;
                    break;
                case "Oct":
                    inputMonth = Oct;
                    MoneyInMonth = moneyPerHour * hoursPerDay * Oct;
                    break;
                case "Nov":
                    inputMonth = Nov;
                    MoneyInMonth = moneyPerHour * hoursPerDay * Nov;
                    break;
                case "Dec":
                    inputMonth = Dec;
                    MoneyInMonth = moneyPerHour * hoursPerDay * Dec;
                    break;
            }

            if (MoneyInMonth > 700)
            {
                MoneyInMonth += (MoneyInMonth / 100) * 10;

            }

            else if (MoneyInMonth >= 800)
            {
                MoneyInMonth += 80;
            }


            if (MoneyInMonth >= priceOfItem)
            {
                Console.WriteLine("Money left = {0:F2} leva.",MoneyInMonth-priceOfItem);
            }

            else if (MoneyInMonth <= priceOfItem)
            {
                Console.WriteLine("Not enough money. {0:F2} leva needed.",priceOfItem - MoneyInMonth);
            }
        }
    }
}
