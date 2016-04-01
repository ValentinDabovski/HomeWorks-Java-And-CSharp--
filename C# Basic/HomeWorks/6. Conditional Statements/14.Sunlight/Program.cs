namespace Sunlight
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Sunlight
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3 * n; i++)
            {
                if (i == (3 * n) / 2)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }

            Console.WriteLine();

            int firstBeamPosition = 1;
            int secondBeamPosition = (3 * n) / 2;
            int thirdBeamPosition = (3 * n) - 2;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < 3 * n; j++)
                {
                    if (j == firstBeamPosition || j == secondBeamPosition || j == thirdBeamPosition)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }

                firstBeamPosition++;
                thirdBeamPosition--;

                Console.WriteLine();
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', n));
                Console.Write(new string('*', n));
                Console.Write(new string('.', n));
                Console.WriteLine();
            }

            Console.WriteLine(new string('*', 3 * n));

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', n));
                Console.Write(new string('*', n));
                Console.Write(new string('.', n));
                Console.WriteLine();
            }

            firstBeamPosition--;
            thirdBeamPosition++;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < 3 * n; j++)
                {
                    if (j == firstBeamPosition || j == secondBeamPosition || j == thirdBeamPosition)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }

                firstBeamPosition--;
                thirdBeamPosition++;

                Console.WriteLine();
            }

            for (int i = 0; i < 3 * n; i++)
            {
                if (i == (3 * n) / 2)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }

            Console.WriteLine();
        }
    }
}