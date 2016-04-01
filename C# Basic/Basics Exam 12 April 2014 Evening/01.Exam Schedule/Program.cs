using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exam_Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingHour = int.Parse(Console.ReadLine());
            int startingMinutes = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            int durationHours = int.Parse(Console.ReadLine());
            int durationMinutes = int.Parse(Console.ReadLine());

            int hourSum = (startingHour + durationHours);
            int minutesSum = (startingMinutes + durationMinutes);

            if (minutesSum >= 60 )
            {
                minutesSum %= 60;
                hourSum += 1;
            }

            if (hourSum >= 12)
            {
                if (hourSum == 12)
                {
                    hourSum = 12;

                }

                else
                {
                    hourSum %= 12;
                }
                
                if (partOfDay == "AM")
                {
                    partOfDay = "PM";
                }

                else
                {
                    partOfDay = "AM";
                }
               
            }
            Console.WriteLine("{0}:{1}:{2}", hourSum.ToString().PadLeft(2, '0'), minutesSum.ToString().PadLeft(2, '0'), partOfDay);
        }
    }
}
