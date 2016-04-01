using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numerology
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split('.', ' ');

            long sum = Convert.ToInt64(input[0]) * Convert.ToInt64(input[1]) * Convert.ToInt64(input[2]);
            char[] name = input[3].ToCharArray();
            long result = 0;
            
            if (Convert.ToInt64(input[1])  % 2 != 0)
            {
                sum = (long)Math.Pow(sum, 2);
            }


            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsDigit(name[i]))
                {
                    sum += name[i] - '0';
                }



                else if (Char.IsLetter(name[i]) && Char.IsUpper(name[i]))
                {
                    sum += (name[i] - '@') * 2;
                }

                else if (Char.IsLetter(name[i]) && Char.IsLower(name[i]))
                {

                    sum += name[i] - '`';
                }    
            }

            do
            {
                result = 0;

                while (sum > 0)
                {
                    result += sum % 10;
                    sum /= 10;
                }

                sum = result;
            } while (sum > 13);

            Console.WriteLine(sum);
        }
    }
}
 