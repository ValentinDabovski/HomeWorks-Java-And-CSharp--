using System;
using System.Linq;
class CurrencyCheck

{
    static void Main()
    {
        decimal rubles = decimal.Parse(Console.ReadLine());
        decimal dollars = decimal.Parse(Console.ReadLine());
        decimal euro = decimal.Parse(Console.ReadLine());
        decimal levaB = decimal.Parse(Console.ReadLine());
        decimal levaM = decimal.Parse(Console.ReadLine());

        rubles *= 3.5m / 100m;
        dollars *= 1.5m;
        euro *= 1.95m;
        levaB /= 2m;


        var list = new[] { rubles, dollars, euro, levaB, levaM };
        decimal min = list.Min();
        Console.WriteLine("{0:0.00}", min);
    }
}

