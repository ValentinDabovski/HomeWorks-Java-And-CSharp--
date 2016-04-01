using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Panda_Scotland_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char ch = 'A';
            int alphabetCount = 0;
            int symbol = 1;
            int charp = n - 4;

            Console.Write(ch);
            alphabetCount++;
            Console.Write(new string('#',n-2));

            Console.WriteLine(Convert.ToChar(ch+alphabetCount));
           



            for (int i = 0; i < n / 2 -1; i++)
            {
                alphabetCount++;
                alphabetCount = isReached(alphabetCount);
                Console.WriteLine(alphabetCount);

                Console.Write(new string('~', symbol) + (Convert.ToChar(ch + alphabetCount)));

                Console.Write(new string('#', charp));
                alphabetCount++;
                Console.Write((Convert.ToChar(ch + alphabetCount) + new string('~', symbol)));
                Console.WriteLine();
                charp -= 2;
                symbol++;

            }
            alphabetCount++;
            Console.WriteLine(new string('-', n / 2) + (Convert.ToChar(ch + alphabetCount) + (new string('-', n / 2))));



        }

        public static int isReached(int counter)
        {
            if (counter >= 1)
            {
                counter = 0;
            }

            return counter;
        }
    }
}
