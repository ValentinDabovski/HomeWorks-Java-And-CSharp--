using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] inputLinesStudent = Console.ReadLine().Split();
            string[] inputLinesWorker = Console.ReadLine().Split();

            try
            {
                var student = new Student(inputLinesStudent[0], inputLinesStudent[1], inputLinesStudent[2]);
                var worker = new Worker(inputLinesWorker[0], inputLinesWorker[1], decimal.Parse(inputLinesWorker[2]), int.Parse(inputLinesWorker[3]));
                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                 
            }   
        }
    }
}
