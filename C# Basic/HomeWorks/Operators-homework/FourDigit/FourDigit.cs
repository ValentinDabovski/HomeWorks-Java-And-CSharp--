using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigit
{
    class FourDigit
    {
        static void Main()
        {
            Console.WriteLine("Enter 4 digit number, cannot start with 0");
            int numb = int.Parse(Console.ReadLine());
            while ( numb > 9999 || numb < 1000)
            {
                Console.WriteLine("Number must be four-digit and cannot start with 0 please try again.");
                numb = int.Parse(Console.ReadLine());
            }

            int num1 = numb / 1000;
            int num2 = (numb / 100) % 10;
            int num3 = (numb / 10) % 10;
            int num4 = numb % 10;
            int sum = num1 + num2 + num3 + num4;

            Console.WriteLine("sum of digits :{0}",sum);
            Console.WriteLine("reversed: {0}{1}{2}{3}", num4,num3,num2,num1);
            Console.WriteLine("last digit in first position: {0}{1}{2}{3}",num4,num2,num3,num1);
            Console.WriteLine("second and third digits exchanged: {0}{1}{2}{3}", num1,num3,num2,num4);

        }
    }
}
