using System;

    class NumbersFrom1ToN
{
        static void Main()
        {
        Console.WriteLine("Enter positive number");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();
            for (int i = 1; i <= n; i++)
             {
               Console.WriteLine(i);            
             }

        }
    }


