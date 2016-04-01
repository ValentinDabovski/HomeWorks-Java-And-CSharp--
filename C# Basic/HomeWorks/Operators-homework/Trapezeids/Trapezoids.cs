using System;




 class Trapezoids
    {
        static void Main()

        {
            Console.WriteLine("To calculate trapezoid area enter side 'a' and 'b'  also enter hight 'h'");
           
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            

            // A = (a+b) / (2) * h


            double area = (a + b) / (2) * h;
            Console.WriteLine(area);
 
            
        }
    }

