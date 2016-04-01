using System;




    class CheckBit
    {
        static void Main()
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position ");
            int p = int.Parse(Console.ReadLine());

            int nrightP = n >> p;
            int bit = nrightP & 1;
            bool bitCheck = bit == 1;
            Console.WriteLine(bitCheck);
           
        }
    }
