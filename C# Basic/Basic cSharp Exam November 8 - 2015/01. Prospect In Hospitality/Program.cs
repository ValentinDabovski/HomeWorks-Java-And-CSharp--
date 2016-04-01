using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Prospect_In_Hospitality
{
    class Program
    {
        static void Main(string[] args)
        {
            uint builders = uint.Parse(Console.ReadLine());
            uint receptionists = uint.Parse(Console.ReadLine());
            uint chambermaids = uint.Parse(Console.ReadLine());
            uint technicians = uint.Parse(Console.ReadLine());
            uint otherStaff = uint.Parse(Console.ReadLine());
            decimal nikiSalaryUSD = decimal.Parse(Console.ReadLine());
            decimal UsCurrencyRate = decimal.Parse(Console.ReadLine());
            decimal yourSalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal buildersMoney = builders * 1500.04m;
            decimal receptionistsMoney = receptionists * 2102.10m;
            decimal chamermaidsMoney = chambermaids * 1465.46m;
            decimal techniciansMoney = technicians * 2053.33m;
            decimal otherStaffMoney = otherStaff * 3010.98m;
            decimal nikiSalaryLeva = nikiSalaryUSD * UsCurrencyRate;

            decimal[] sumOfAllStaff = { buildersMoney, receptionistsMoney, chamermaidsMoney, techniciansMoney, otherStaffMoney, nikiSalaryLeva, yourSalary };
            
            decimal moneyAmount = sumOfAllStaff.Sum();
            decimal moneyLeft = budget - moneyAmount;
            decimal moneyNeeded = moneyAmount - budget;

            Console.WriteLine("The amount is: {0:F2} lv.",moneyAmount);

            if (budget >= moneyAmount)
            {
                Console.WriteLine("YES \\ Left: {0:F2} lv.",moneyLeft);
            }
            else
            {
                Console.WriteLine("NO \\ Need more: {0:F2} lv.",moneyNeeded);
            }
        }
    }
}
