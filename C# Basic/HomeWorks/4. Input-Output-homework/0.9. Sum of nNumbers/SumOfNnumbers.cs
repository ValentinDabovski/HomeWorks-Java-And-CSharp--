using System;


namespace _0._9.Sum_of_nNumbers
{
    class SumOfNnumbers
    {
        static void Main()
        {
            long numberCount = int.Parse(Console.ReadLine());
            double sum = 0;
            double number = 0;

            for (int i = 0; i < numberCount; i++)
            {
                number = double.Parse(Console.ReadLine());

                sum += number;
              
            }

            Console.WriteLine(sum);

        }
    }
}
