using System;

class PrintSequence
{
    static void Main()
    {
        // using for loop and 
        int numberToPrint;
        for (int i = 1; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                numberToPrint = i;
            }
            else
            {
                numberToPrint = i * (-1);
            }
            Console.WriteLine(numberToPrint);
        }
    }
}