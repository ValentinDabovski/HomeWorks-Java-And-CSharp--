using System;

class DivideBy7And5 
{
    static void Main()
    {
        Console.WriteLine("Enter Number: ");
        int x = int.Parse(Console.ReadLine());
        if (x % 7 == 0 && x % 5 == 0)
        {
            Console.WriteLine("True: Number is divisible by 7 & 5");
        }
        else
        {
            Console.WriteLine("False: Number is NOT divisible by 7 & 5 ");
        }

    }
}