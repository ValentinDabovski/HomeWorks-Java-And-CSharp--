using System;



    class HalfSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            for ( int i = 0; i < 2*n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i<n)
                {
                    firstNumber += num;

                }
                else 
                {
                    secondNumber += num;
                }
                if (firstNumber==secondNumber)
                {
                    Console.WriteLine(" Yes Sum = {0}", firstNumber);
                }
                else
                {
                    Console.WriteLine("No, diff ={0}", Math.Abs(firstNumber - secondNumber));
                }
            }
        }
    }
