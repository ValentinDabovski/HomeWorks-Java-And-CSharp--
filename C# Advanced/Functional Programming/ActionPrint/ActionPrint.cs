using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


namespace ActionPrint
{
    public class ActionPrint
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            ApllyAction(input, x => Console.WriteLine(x));
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
