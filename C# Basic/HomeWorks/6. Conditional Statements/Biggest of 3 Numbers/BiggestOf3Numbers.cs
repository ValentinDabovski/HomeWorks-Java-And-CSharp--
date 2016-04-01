using System;

    class BiggestOf3Numbers
    {
        static void Main()
        {

        Console.WriteLine("Enter three numbers to check wich is the biggest");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.Write("Biggest Number: " );
        Console.WriteLine(Math.Max(Math.Max(a, b), c));
        

        
    }
    }

