using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SequencesOfEqual_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');

            List<string> input = new List<string>();
            List<string> strInput = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                input.Add(str[i]);
               
            }

            for (int i = 0; i < input.Count; i++)
            {
                strInput = input.FindAll(p => p.Equals(p));
            }

            foreach (string item in strInput)
            {
                if (item.Equals(item.Length -1))
                {
                    Console.Write("{0",item);
                }

                else
                {
                    Console.WriteLine("{0}",item);
                }
            }

        }
    }
}
