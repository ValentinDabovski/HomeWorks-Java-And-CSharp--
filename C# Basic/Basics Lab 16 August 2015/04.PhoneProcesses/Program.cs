using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhoneProcesses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] PhoneStartingPercentage = Console.ReadLine().Split('%');
            int phoneBattery = Convert.ToInt32(PhoneStartingPercentage[0]);

            string input = Console.ReadLine();         

            int appCounter = 0;
            int appBatterySum = 0;
            int appBattery = 0;

            while (true)
            {
                string[] splitedInput = input.Split(new string[] { "_", "%" }, StringSplitOptions.None);
                
                
                   
                if (splitedInput[0].ToLower() == "end")
                {                  
                    break;
                }


                appBattery = Convert.ToInt32(splitedInput[1]);

                appBatterySum += appBattery;
                
                input = Console.ReadLine();
                appCounter++;

                             
            }

            if (phoneBattery - appBattery<= 0)
            {
                Console.WriteLine("Phone Off");
                
            }


            else if (phoneBattery - appBatterySum <= 15)
            {            

                appCounter = (Math.Abs(-1));
                Console.WriteLine("Connect charger -> {0}%", ((Math.Abs(phoneBattery - appBatterySum) - 1)));
                Console.WriteLine("Programs left -> {0}", appCounter);
            }
            
             else if (phoneBattery >= appBatterySum)
            {
                Console.WriteLine("Successful complete -> {0}%",phoneBattery-appBatterySum);
            }                     
            
        }
    }
}
