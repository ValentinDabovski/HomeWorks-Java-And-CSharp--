using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Perfect_Girlfriend
{
    class Program
    {
        static void Main(string[] args)
        {
            int girlAprove = 0;
            while (true)
            {
                string[] input = Console.ReadLine().Split('\\');
                

                if (input[0] == "Enough dates!")
                {
                    break;
                }
                
                string dayOfWeek = input[0];
                int dayOfWeekNum = 0;
                int sumNumber = 0;
                string telephoneNumber = input[1];
                string bra = input[2];
                bra.ToCharArray();
                string braDigits = string.Empty;
                char braLetter = '\0';
                double sumOfBra = 0;
                string name = input[3];
                char[] nameReverse = name.ToCharArray();
                Array.Reverse(nameReverse);
                double nameResult = 0;
                double generalResult = 0;


                char nameLetter = '\0';



                // day of week number (1-7)
                switch (dayOfWeek)
                {
                    case "Monday":
                        dayOfWeekNum = 1;


                        break;
                    case "Tuesday":
                        dayOfWeekNum = 2;
                        break;
                    case "Wednesday":
                        dayOfWeekNum = 3;

                        break;
                    case "Thursday":
                        dayOfWeekNum = 4;
                        break;
                    case "Friday":
                        dayOfWeekNum = 5;
                        break;
                    case "Saturday":
                        dayOfWeekNum = 6;
                        break;
                    case "Sunday":
                        dayOfWeekNum = 7;
                        break;
                }

                //sum tel number
                for (int i = 0; i < telephoneNumber.Length; i++)
                {
                    sumNumber += int.Parse(telephoneNumber[i].ToString());
                }

                // get digit and letter form bra size 
                for (int i = 0; i < bra.Length; i++)
                {
                    if (char.IsDigit(bra[i]))
                    {
                        braDigits += (bra[i].ToString());
                    }

                    else if (char.IsLetter(bra[i]))
                    {
                        braLetter += bra[i];

                    }
                }

                // bra math result
                sumOfBra = Convert.ToInt32(braDigits) * Convert.ToByte(braLetter);

                // first name letter to ASCII 
                for (int i = nameReverse.Length - 1; i < nameReverse.Length; i++)
                {
                    nameLetter += nameReverse[i];
                }

                // math results
                nameResult = Convert.ToByte(nameLetter) * nameReverse.Length;
                sumOfBra = Convert.ToInt32(braDigits) * Convert.ToByte(braLetter);
                generalResult = Convert.ToInt32(dayOfWeekNum) + ((Convert.ToInt32(sumNumber) + sumOfBra)) - nameResult;



                if (generalResult >= 6000)
                {
                    Console.WriteLine("{0} is perfect for you.", input[3]);
                    girlAprove++;

                }


                else if (generalResult <= 6000)
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", input[3]);
                    
                }
                
            }
            
            Console.WriteLine(girlAprove);
        }

    }
}
