using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Drunk_Ani
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfCandite = Console.ReadLine();

            var date = (DateTime.Now);

            var date2 = DateTime.FromOADate(42300d);


            Console.WriteLine(date2);

           // Console.WriteLine("{0} you have only {1} days to apply dor the spring semester at Software University!",nameOfCandite);
        }

    }
}
