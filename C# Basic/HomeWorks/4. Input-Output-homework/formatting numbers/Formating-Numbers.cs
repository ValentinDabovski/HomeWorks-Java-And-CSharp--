using System;


class ConsoleInputOutput
{
    static void Main()
    {


        Console.WriteLine("PLease Enter Int Number: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("PLease Enter Double Number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("PLease Enter Double Number: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("|{0,-10:X} |{1,10}| {2,10:F2} |{3,-10:F3}|", a, Convert.ToString(a, 2), b, c);

    }
}

