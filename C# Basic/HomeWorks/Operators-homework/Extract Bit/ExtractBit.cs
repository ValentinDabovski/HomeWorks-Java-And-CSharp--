
using System;

class ExtractBit
{
    static void Main()
    {
        Console.WriteLine("Enter the integer number:");
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int nRightP = n >> p;
        int bit = nRightP & 1;
        Console.WriteLine(bit);
    }
}