using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Enter a , b and c ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            if (D > 0 && a != 0)
            {
                Console.WriteLine("x1 = {0}; x2={1} ", (-b + D) / (2.0 * a), (-b - D) / (2.0 * a));
            }

            else if (D==0&&a!=0)
            {
                Console.Write("x1=x2={0}", -b / (2.0 * a));
            }

            else
            {
                Console.WriteLine("No Real Roots ");
            }
        }

    }

