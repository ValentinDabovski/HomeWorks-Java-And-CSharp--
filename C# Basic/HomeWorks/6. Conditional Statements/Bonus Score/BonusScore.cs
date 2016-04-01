using System;


    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter Score  within scope 1 to 9 ");
            double score = double.Parse(Console.ReadLine());

            while (score <= 0 || score >=10)
            {
                Console.WriteLine("Invalid score");
                score = double.Parse(Console.ReadLine());
            }

            if (score >= 1.0 && score <= 3.0)
            {
                Console.WriteLine("Your score is : {0}" , score * 10);
                
            }

            else if (score >= 4.0 && score <= 6.0 )
            {
                Console.WriteLine("Your score is: {0}", score * 100);
            }
             else if (score >= 7.0 && score <= 9.0)
            {
                Console.WriteLine( "Your score is : {0}", score * 1000);
            }
        }
    }
