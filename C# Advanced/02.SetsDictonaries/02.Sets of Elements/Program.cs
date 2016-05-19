using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nM = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            HashSet<int> nNumbers = new HashSet<int>();
            HashSet<int> mNumbers = new HashSet<int>();

            for (int i = 0; i < nM[0]; i++)
            {
                int n = int.Parse(Console.ReadLine());
                nNumbers.Add(n);
            }

            for (int i = 0; i < nM[1]; i++)
            {
                int m = int.Parse(Console.ReadLine());
                mNumbers.Add(m);
            }


            nNumbers.IntersectWith(mNumbers);

            foreach (var item in nNumbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
