using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Bank_Account_Data
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name Account: ");
            string firstNameAc = Console.ReadLine();
            Console.WriteLine("Enter Middle Name Account: ");
            string middleNameAc = Console.ReadLine();
            Console.WriteLine("Enter Last Name Account: ");
            string lastNameAC = Console.ReadLine();
            Console.WriteLine("Enter Balance Account: ");
            string balance = Console.ReadLine();
            Console.WriteLine("Enter Bank Name: ");
            string BankName = Console.ReadLine();
            Console.WriteLine("Enter IBAN Account:");
            string IBAN = Console.ReadLine();
            Console.WriteLine("Enter First Card Number: ");
            long firstCardNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Card Number: ");
            long secondCardNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Card Number");
            long thirdCardNumber = long.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("First Name: {0}", firstNameAc);
            Console.WriteLine("Middle Name: {0}", middleNameAc);
            Console.WriteLine("Last Name: {0}", lastNameAC);
            Console.WriteLine("Balance: {0}", balance);
            Console.WriteLine("Bank Name: {0}", balance);
            Console.WriteLine("IBAN: {0}", IBAN);
            Console.WriteLine("First Card Number: {0}", firstCardNumber);
            Console.WriteLine("Second Card Number: {0}", secondCardNumber);
            Console.WriteLine("Third Card Number: {0}", thirdCardNumber);

        }
    }
}
