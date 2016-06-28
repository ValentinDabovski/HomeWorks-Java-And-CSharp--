using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Creating_Constructors
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> personslList = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] inputLines = Console.ReadLine().Split(); 
                string name = inputLines[0];
                int age = int.Parse(inputLines[1]);

                var person = new Person(name, age);
                personslList.Add(person);
                
            }

            var sortedListFromPerson = personslList.Where(x => x.Age > 30).OrderBy(x => x.FirstName);

            foreach (Person person in sortedListFromPerson)
            {
                Console.WriteLine($"{person.FirstName} - {person.Age}");
            }
        }
    }
}
