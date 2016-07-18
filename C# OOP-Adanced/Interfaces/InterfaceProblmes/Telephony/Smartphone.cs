using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ICall, IBrowse
    {
        public string Browse(List<string> stringSitesToVisit)
        {
           StringBuilder stringBuilder = new StringBuilder();

            foreach (var site in stringSitesToVisit)
            {
                if (site.Any(x=> char.IsDigit(x)))
                {
                    stringBuilder.AppendLine("Invalid URL!");
                    continue;
                }
                stringBuilder.AppendLine($"Browsing: {site}!");
            }
            return stringBuilder.ToString().Trim();
        }

        public string Call(List<string> numbersToCall)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var number in numbersToCall)
            {
                if (number.Any(x=> char.IsLetter(x)))
                {
                    stringBuilder.AppendLine("Invalid number!");
                    continue;
                }
                stringBuilder.AppendLine("Calling... " + number);
            }
            return stringBuilder.ToString().Trim();
        }
    }
}
