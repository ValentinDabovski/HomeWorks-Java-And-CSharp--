using System;
using System.Numerics;

class PetarsGame
{
    static void Main(string[] args)
    {
        BigInteger startingNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger endNumber = BigInteger.Parse(Console.ReadLine());
        string replascmentString = Console.ReadLine();
        BigInteger sum = 0;
        string stringedSum = Convert.ToString(sum);
        string output;


        for (BigInteger i = startingNumber; i < endNumber; i++)
        {
            if (i % 5 == 0)
            {
                sum += i;
            }
            else
            {
                sum += (i % 5);
            }

        }

        if (sum % 2 == 0)
        {
            stringedSum = Convert.ToString(sum);
            string firstNumber = Convert.ToString(sum)[0].ToString();
            output = stringedSum.Replace(firstNumber, replascmentString);
            Console.WriteLine(output);
        }
        else
        {
            stringedSum = Convert.ToString(sum);
            string firstNumber = Convert.ToString(sum)[stringedSum.Length - 1].ToString();
            output = stringedSum.Replace(firstNumber, replascmentString);
            Console.WriteLine(output);
        }
    }
}