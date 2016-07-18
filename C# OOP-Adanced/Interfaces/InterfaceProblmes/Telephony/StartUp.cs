using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> numbersToCall = new List<string>();
            List<string> SitesToVisit = new List<string>();

            string[] inputNumbersLines = Console.ReadLine().Split();

            var phone = new Smartphone();

            for (int i = 0; i < inputNumbersLines.Length; i++)
            {
                numbersToCall.Add(inputNumbersLines[i]);
            }


            string[] inputSitesLines = Console.ReadLine().Split();

            for (int i = 0; i < inputSitesLines.Length; i++)
            {
                SitesToVisit.Add(inputSitesLines[i]);
            }

         
            try
            {
                Console.WriteLine(phone.Call(numbersToCall));
                Console.WriteLine(phone.Browse(SitesToVisit));
                
            }
            catch (ArgumentException ae )
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}