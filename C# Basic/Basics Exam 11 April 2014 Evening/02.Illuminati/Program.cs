using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Illuminati
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            char[] inputChar = string.Join("", input).ToCharArray();
            
            
            int a = 65;
            int e = 69;
            int i = 73;
            int o = 79;
            int u = 85;


            int letterA = 0;
            int letterE = 0;
            int letterI = 0;
            int letterO = 0;
            int letterU = 0;
            

            int vowels = 0;
            int Sum = 0;


            for (int j = 0; j < inputChar.Length; j++)
            {
                if (inputChar[j] == 'a' || inputChar[j] == 'A')
                {
                    vowels++;
                    letterA++;
                    
                }
                

                else if (inputChar[j] == 'e' || inputChar[j] == 'E')
                {
                    vowels++;
                    letterE++;
                }

                else if (inputChar[j] == 'i' || inputChar[j] == 'I')
                {
                    vowels++;
                    letterI++;
                    
                }

                else if (inputChar[j] == 'o' || inputChar[j] == 'O')
                {
                    vowels++;
                    letterO++;
                    
                }

                else if (inputChar[j] == 'u' || inputChar[j] == 'U')
                {
                    vowels++;
                    letterU++;
               
                }

                continue;
            }

            Sum = (letterA * a) + (letterE * e) + (letterI * i) + (letterO * o) + (letterU * u);

            Console.WriteLine(vowels);
            Console.WriteLine(Sum);
            
        }
    }
}

