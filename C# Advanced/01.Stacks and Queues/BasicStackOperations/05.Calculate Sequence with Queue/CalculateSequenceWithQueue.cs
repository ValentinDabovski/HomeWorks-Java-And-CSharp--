using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Sequence_with_Queue
{
    class CalculateSequenceWithQueue
    {
        static void Main()
        {

            long n = long.Parse(Console.ReadLine());
            long numbS;

            Queue<long> queueNumbers = new Queue<long>();
            List<long> numbersFromQueue = new List<long>();

            queueNumbers.Enqueue(n);

            for (int i = 0; i < 50; i++)
            {
                numbS = queueNumbers.Peek() + 1;
                queueNumbers.Enqueue(numbS);


                numbS = (queueNumbers.Peek() * 2) + 1;
                queueNumbers.Enqueue(numbS);


                numbS = queueNumbers.Peek() + 2;
                queueNumbers.Enqueue(numbS);

                numbersFromQueue.Add(queueNumbers.Peek());
                queueNumbers.Dequeue();
   
            }

            foreach (var item in numbersFromQueue)
            {
                Console.Write(item + " ");
            }
        }
    }
}
