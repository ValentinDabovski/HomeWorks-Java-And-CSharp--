using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindEvensOrOdds
{
    class EvensOrOdds
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int startNum = int.Parse(numbers[0]);
            int endNum = int.Parse(numbers[1]);
            string numType = Console.ReadLine();

            int divideresult = 0;
            if (numType == "odd")
            {
                divideresult = 1;
            }

            List<int> list = Enumerable.Range(startNum, endNum - startNum + 1).ToList();

            List<int> filteredList = Filter(list, n => n % 2 == divideresult);

            Console.WriteLine(string.Join(" ", filteredList));
        }

        private static List<int> Filter(List<int> list, Predicate<int> pred)
        {
            List<int> result = new List<int>();
            foreach (var num in list)
            {
                if (pred(num))
                {
                    result.Add(num);
                }
            }

            return result;
        }
    }
}