
using System;

class CalculateNFactorialdevidedKFactorial
{
    static void Main()
    {
        Console.WriteLine("Enter two integers n and k in the range (1 < k < n < 100):");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        if (k <= 1 || k > n || n <= 1 || n >= 100 || k >= 100)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        int factorialN = 1;
        int factorialK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
        }
        Console.WriteLine("{0}", factorialN / factorialK);
    }
}