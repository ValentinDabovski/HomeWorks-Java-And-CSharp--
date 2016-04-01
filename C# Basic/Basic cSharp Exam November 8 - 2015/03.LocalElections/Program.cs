using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LocalElections
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCandidates = int.Parse(Console.ReadLine());
            int voteOfElector = int.Parse(Console.ReadLine());
            string votingSybol = Console.ReadLine().ToUpper();



            string boxX = "...+-----+...\n";
                  boxX += "...|.\\./.|...\n";
            boxX += voteOfElector.ToString().PadLeft(2, '0') + ".|..X..|...\n";
            boxX += "...|./.\\.|...\n";
            boxX += "...+-----+...\n";

            string boxV = "...+-----+...\n";
            boxV += "...|\\.../|...\n";
            boxV += voteOfElector.ToString().PadLeft(2, '0') + ".|.\\./.|...\n";
            boxV += "...|..V..|...\n";
            boxV += "...+-----+...\n";


         

            string topBottom = ".............\n";

            string boxUsing = string.Empty;

            if (votingSybol == "X")
                boxUsing = boxX;
            else
                boxUsing = boxV;


            for (int i = 1; i <= numberCandidates; i++)
            {
                string boxEmpty = "...+-----+...\n";
                boxEmpty += "...|.....|...\n";
                boxEmpty += i.ToString().PadLeft(2, '0') + ".|.....|...\n";
                boxEmpty += "...|.....|...\n";
                boxEmpty += "...+-----+...\n";

                Console.Write(topBottom );
                if (i == voteOfElector)
                {
                    Console.Write(boxUsing);
                   
                }

                else
                {
                    Console.Write(boxEmpty);
                 
                }
                
            }
            Console.Write(topBottom);

        }
    }
}
