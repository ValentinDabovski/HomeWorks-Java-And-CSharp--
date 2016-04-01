using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class CirclePerimeter
    {
        static void Main()
        {
            Console.WriteLine("Enter radius: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter {0:F2}", 2 * Math.PI * r);
            Console.WriteLine("Area {0:F2}", Math.PI * Math.Pow(r, 2));
        }
    }

