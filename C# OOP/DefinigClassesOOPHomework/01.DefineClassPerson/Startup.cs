using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01.DefineClassPerson
{
    public class Startup
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            var personOne = new Person("Gosho",20);
            var personTwo = new Person("Pesho",18);
            var personThree = new Person("Stamat", 43);

        }
    }
}
