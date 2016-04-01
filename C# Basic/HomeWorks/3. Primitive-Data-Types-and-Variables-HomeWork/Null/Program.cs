using System;



    class Null
    {
        static void Main()
        {
            int? valueInt = null;
            double? valueDouble = null;
            Console.WriteLine(valueInt);
            Console.WriteLine(valueDouble);
            Console.WriteLine(valueInt + 2);
            Console.WriteLine(valueDouble + 2);
            Console.WriteLine(valueInt + null);
            Console.WriteLine(valueDouble + null);
        }
    }
