using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideTheBuilding
{
    class InsideTheBuilding
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());

            double cableCount = 0;
            double cableSum = 0;
            double cableLose = 0;
            double studentCable = 0;
            double cableFullLenght = 0;
            double remineder = 0;

            double measureInNumbers = 0;
            string measureInString = string.Empty;

            for (int i = 0; i < (n * 2) / 2; i++)
            {
                measureInNumbers = int.Parse(Console.ReadLine());
                measureInString = Console.ReadLine();

                if (measureInString == "meters")
                {
                    measureInNumbers *= 100;
                    cableSum += measureInNumbers;
                    cableCount++;
                }

                else if (measureInNumbers < 20)
                {
                    measureInNumbers = 0;
                }

                else if (measureInString == "centimeters")
                {
                    measureInNumbers *= 1;
                    cableSum += measureInNumbers;
                    cableCount++;

                }

            }
            cableLose = cableCount * 2;
            cableFullLenght = cableSum - cableLose;
            studentCable = cableFullLenght / 504;

            remineder = Math.Floor(studentCable) * 504;
           
            Console.WriteLine(Math.Floor(studentCable));

            Console.WriteLine(cableFullLenght-remineder);


                      
        }
         
    }
}
