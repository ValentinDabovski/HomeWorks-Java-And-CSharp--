﻿using System;

class CalculateSumsOfFactorials
{
    static void Main()
    {
        Console.WriteLine("Enter  n and x:");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int factorial = 1;
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += (factorial / Math.Pow(x, i));
        }
        Console.WriteLine("{0:F5}", sum);
    }
}