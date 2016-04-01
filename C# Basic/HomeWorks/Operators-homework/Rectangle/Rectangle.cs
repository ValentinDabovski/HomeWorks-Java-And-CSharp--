using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        static void Main()
        {
            Console.WriteLine("Enter rectangle's width: ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter rectangle's height: ");
            double h = double.Parse(Console.ReadLine());

            // P=a+b+a+b 
            // S=a*b 

            double area = w * h;
            double perimeter = w + h + w + h;

            Console.WriteLine("Rectangle's: Area:{0}: ", area);
            Console.WriteLine("Rectangle's: Perimeter:{0}", perimeter);
        }
    }
}
