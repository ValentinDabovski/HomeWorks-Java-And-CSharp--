using System;

    class ExchangeIfGrater
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers  first number must be grater the secind number");
            double firstnum = double.Parse(Console.ReadLine());
            double secondnum = double.Parse(Console.ReadLine());

            if ( firstnum > secondnum  )
            {
                Console.WriteLine("{0} {1} ",secondnum,firstnum);
            }

            while ( firstnum < secondnum )
            {
                Console.WriteLine(" second number is greater then the first number please try again: ");

                firstnum = double.Parse(Console.ReadLine());
                secondnum = double.Parse(Console.ReadLine());

                if (firstnum > secondnum)
                {
                    Console.WriteLine("{0} {1} ", secondnum, firstnum);
                }


            }
              
            
        }
    }

