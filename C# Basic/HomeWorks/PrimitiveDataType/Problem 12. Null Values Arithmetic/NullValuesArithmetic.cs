using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Null_Values_Arithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? valueInt = null;
            double? valueDouble = null;
            Console.WriteLine(valueInt);
            Console.WriteLine(valueDouble);
            Console.WriteLine(valueInt + 2);
            Console.WriteLine(valueDouble + 2);
            Console.WriteLine(valueInt + null);
            Console.WriteLine(valueDouble + null);
        }
    }
}
