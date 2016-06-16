using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Students_by_Age
{
    public class StudentsByAge
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<int, List<string>> studentsDictionary = new Dictionary<int, List<string>>();


            while (input != "END")
            {
                string[] args = input.Split();
                int age = int.Parse(args[2]);
                string firstName = args[0];
                string lastName = args[1];

                if (!studentsDictionary.ContainsKey(age))
                {
                    studentsDictionary.Add(age, new List<string>());
                }

                studentsDictionary[age].Add(firstName + " " + lastName);

                input = Console.ReadLine();
            }

            var sortedStudents = studentsDictionary.Where(x => x.Key < 25 && x.Key > 17);

            foreach (var student in sortedStudents)
            {

                Console.Write(string.Join(" ", student.Value));
                Console.WriteLine(" " + student.Key);
            }
        }
    }
}
