using System;

namespace Age_After_10_Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Type your Age");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Age After 10 years will be: {0}", Age + 10);
        }
    }
}
 