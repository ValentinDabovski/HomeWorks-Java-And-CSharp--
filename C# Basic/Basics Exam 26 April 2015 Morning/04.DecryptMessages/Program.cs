using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DecryptMessages
{
    class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine().ToLower();


            while (command != "start" && command != "START")
            {
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
        }
    }
}
