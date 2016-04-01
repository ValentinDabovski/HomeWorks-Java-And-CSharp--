using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter Number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <=n; i++)
            {
                if((i % 2) == 0)
                {
                    Console.WriteLine(i+ ",");
                }
                else
                {
                    Console.WriteLine("-" + i + ",");
                }
            }
        }
    }


