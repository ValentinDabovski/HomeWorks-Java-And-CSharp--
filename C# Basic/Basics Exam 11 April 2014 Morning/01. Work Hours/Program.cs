using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Work_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            double workHours = double.Parse(Console.ReadLine());
            double deadLine = double.Parse(Console.ReadLine());
            double productivity = double.Parse(Console.ReadLine());

            double workingDays = (deadLine * 0.9) * 12;
            double efficentHours = Math.Floor(workingDays * productivity / 100);
           
         

            if (efficentHours >= workHours)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("{0}",efficentHours-workHours);
            }

            else if (efficentHours <= workHours)
            {
                Console.WriteLine("No");
                Console.WriteLine("{0}",efficentHours - workHours);
            }
           
        }
    }
}
