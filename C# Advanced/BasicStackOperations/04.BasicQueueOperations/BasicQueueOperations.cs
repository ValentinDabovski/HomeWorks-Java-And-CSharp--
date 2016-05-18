using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int elemtsToPop = input[1];
            int elementsCointais = input[2];

            Queue<int> queueNumbers = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                queueNumbers.Enqueue(numbers[i]);
            }

            for (int i = 0; i < elemtsToPop; i++)
            {
                queueNumbers.Dequeue();
            }

            if (queueNumbers.Contains(elementsCointais))
            {
                Console.WriteLine("true");
            }

            else if (queueNumbers.Count == 0)
            {
                Console.WriteLine("0");
            }

            else
            {
                Console.WriteLine(queueNumbers.Min());
            }
        }
    }
}
