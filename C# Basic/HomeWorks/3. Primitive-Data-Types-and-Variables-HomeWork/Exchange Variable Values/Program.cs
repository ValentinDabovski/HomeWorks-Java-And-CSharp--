using System;



    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            b = b - a;
            a = b + a; 
            Console.WriteLine("After");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
    }

