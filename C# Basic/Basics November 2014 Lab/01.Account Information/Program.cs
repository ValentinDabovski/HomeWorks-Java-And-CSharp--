using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Account_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            long clientID = long.Parse(Console.ReadLine());
            decimal accountBalance = decimal.Parse(Console.ReadLine());


            Console.WriteLine("Hello, {0} {1}",firstName,lastName);
            Console.WriteLine("Client id: {0}",clientID);
            Console.WriteLine("Total balance: {0:0.0.0}",accountBalance);

            if (accountBalance >= 0)
            {
                Console.WriteLine("Active: yes");
            }

            else
            {
                Console.WriteLine( "Active: no");
            }

        }
    }
}
