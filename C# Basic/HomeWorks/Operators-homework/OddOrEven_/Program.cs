using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter Number to check if its Prime:");

        int n = int.Parse(Console.ReadLine());


        if (n % 2 == 1)
        {
            Console.WriteLine("True");
        }

        else
        {
            Console.WriteLine("False");
        }
    }
}