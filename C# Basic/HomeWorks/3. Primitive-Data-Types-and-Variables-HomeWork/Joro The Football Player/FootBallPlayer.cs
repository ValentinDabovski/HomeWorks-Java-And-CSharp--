using System;



    class FootboallPlayer
    {
        static void Main()

        {
            Console.WriteLine("Enter 't' for leap year or 'f' for year that is not leap");
            string kindOfYear = Console.ReadLine();
            short p = short.Parse(Console.ReadLine());
            short h = short.Parse(Console.ReadLine());
            if (kindOfYear == "t")
            {
                Console.WriteLine("{0}", h + ((52 - h) * 2 * 1 / 3) + (p * 1 / 2) + 3);
            }
            else if (kindOfYear == "f")
            {
                Console.WriteLine("{0}", h + ((52 - h) * 2 * 1 / 3) + (p * 1 / 2));
            }
        }
    }



