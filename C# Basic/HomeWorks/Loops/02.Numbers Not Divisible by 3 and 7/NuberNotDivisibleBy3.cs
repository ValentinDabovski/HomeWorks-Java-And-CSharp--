using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.WriteLine("Enter Positive integer");
        
        double n = double.Parse(Console.ReadLine());
        while (n < 0)
        {
            Console.WriteLine("Wrong input negative intiger");
            return;    
            
        }   
        
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(" {0} ", i);
                }
            }

            Console.WriteLine();
        
    }
}

