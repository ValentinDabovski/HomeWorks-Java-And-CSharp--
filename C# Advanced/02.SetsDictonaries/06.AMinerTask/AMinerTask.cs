using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var minerDict = new Dictionary<string, string>();

            while (!input.Equals("stop"))
            {
                if (!minerDict.ContainsKey(input))
                {
                    minerDict.Add(input, input = Console.ReadLine());
                }

                input = Console.ReadLine();
            }

            foreach (var item in minerDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
