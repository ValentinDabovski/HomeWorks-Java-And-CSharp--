using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Startup
    {
        static void Main(string[] args)
        {
            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }


            string input = Console.ReadLine();

            ICar f = new Ferrari(input);
            Console.WriteLine(f);
        }
    }
}
