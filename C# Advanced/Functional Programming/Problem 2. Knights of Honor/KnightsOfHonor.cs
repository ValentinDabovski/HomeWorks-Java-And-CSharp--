using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


namespace KnightsOfHonor
{
    public class KnightsOfHonor
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            ApllyAction(input, x => Console.WriteLine("Sir " + x));
        }

        public static void ApllyAction(string[] input, Action<string> act)
        {
            foreach (var item in input)
            {
                act(item);
            }
        }

    }
}
