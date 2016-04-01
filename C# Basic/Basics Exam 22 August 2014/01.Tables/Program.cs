using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            int bundle1 = int.Parse(Console.ReadLine());
            int bundle2 = int.Parse(Console.ReadLine());
            int bundle3 = int.Parse(Console.ReadLine());
            int bundle4 = int.Parse(Console.ReadLine());
            int tableTops = int.Parse(Console.ReadLine());
            int tablesToBeMade = int.Parse(Console.ReadLine());

            int legsSum = 0;

            legsSum = (bundle1 * 1) + (bundle2 * 2) + (bundle3 * 3) + (bundle4 * 4);
            

            if (tableTops < tablesToBeMade)
            {
                Console.WriteLine("less: {0}",tableTops-tablesToBeMade);
                Console.WriteLine("tops needed: {0}, legs needed: {1}",tablesToBeMade-tableTops,0);
            }

            else if (tableTops > tablesToBeMade)
            {
                Console.WriteLine("more: {0}", tableTops-tablesToBeMade);
                Console.WriteLine("tops left: {0}, legs left: {1}", tableTops - tablesToBeMade, legsSum - (tablesToBeMade *4));
            }

            else if (tablesToBeMade == tableTops)
            {
                Console.WriteLine("Just enough tables made: {0}",tableTops);
            }
        }    
    }
}
