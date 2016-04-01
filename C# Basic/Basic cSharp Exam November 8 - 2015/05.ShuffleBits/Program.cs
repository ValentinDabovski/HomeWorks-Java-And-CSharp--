using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShuffleBits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x = uint.Parse(Console.ReadLine());
            uint y = uint.Parse(Console.ReadLine());
            long bitPosX = 0;
            long bitPosY = 0;
            long result = 0;
            int j = 63;


            if (x >= y)
            {
                for (int i = 31; i >= 0; i--)
                {


                    bitPosX = x & (1u << i);
                    bitPosX >>= i;

                    bitPosY = y & (1u << i);
                    bitPosY >>= i;

                    while (j >= 0)
                    {
                        result |= (result | (bitPosX << j));
                        j--;

                        result |= (result | (bitPosY << j));
                        j--;
                        break;
                    }
                }
                Console.WriteLine(result);
            }

            else
            {
                for (int i = 30; i >= 0; i -= 2)
                {
                    bitPosX = x & (3u << i);
                    bitPosX >>= i;

                    bitPosY = y & (3u << i);
                    bitPosY >>= i;


                    while (j >= 0)
                    {
                        result |= (result | (bitPosX << j));
                        j -= 2;

                        result |= (result | (bitPosY << j));
                        j -= 2;
                        break;
                    }

                }
                Console.WriteLine(result / 2);
            }

        }
    }
}
