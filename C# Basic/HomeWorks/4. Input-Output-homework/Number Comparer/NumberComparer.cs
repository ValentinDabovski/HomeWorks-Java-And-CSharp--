using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Enter Number 'a' ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 'b' ");
            double b = double.Parse(Console.ReadLine());
            double result = Math.Max(a, b);
            Console.WriteLine("Greater number is: {0}", result);


        }
    }

