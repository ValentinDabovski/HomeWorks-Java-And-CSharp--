using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStackOperations
{
    class StackOperations
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
          
            int elemetsToPop = Convert.ToInt32(input[1]);
            int elementsCointains = Convert.ToInt32(input[2]);

            string[] numbersToStackArr = Console.ReadLine().Split(' ');

            Stack<int> numbers = new Stack<int>();


            for (int i = 0; i < numbersToStackArr.Length - 1; i++)
            {
               
                numbers.Push(int.Parse(numbersToStackArr[i]));
            }

            for (int i = 0; i < elemetsToPop - 1; i++)
            { 
                numbers.Pop();
            }

    
            if (numbers.Count == 0)
            {
                Console.WriteLine("0");

            }  
            else if (!numbers.Contains(elementsCointains))
            {
                Console.WriteLine(numbers.Min());
            }
            else if (numbers.Contains(elementsCointains))
            {
                Console.WriteLine("true");
            }
        }
    }
}
