using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FireFighters
{
    class FireFighters
    {
        static void Main(string[] args)
        {
            int firefighters = int.Parse(Console.ReadLine());
            int kidds = 0;
            int adults = 0;
            int seniors = 0;
        
            while (true)
            {
                string command = Console.ReadLine();
                command.ToCharArray();

                if (command == "rain")
                {
                    break;
                }

                for (int i = 0; i < command.Length; i++)
                {
                    if (command[i] == 'K')
                    {
                        kidds++;
                      
                        
                    }

                    else if (command[i] == 'A')
                    {
                        adults++;
                        
                       
                    }

                    else if (command[i] == 'S')
                    {
                        seniors ++;
                      
                        
                    }
                }
            }
            Console.WriteLine(kidds);
            Console.WriteLine(adults);
            Console.WriteLine(seniors);
        }
    }
}
