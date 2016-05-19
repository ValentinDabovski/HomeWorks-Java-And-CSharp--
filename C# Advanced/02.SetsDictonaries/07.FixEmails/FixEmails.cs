using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string email;
            var nameEmailDict = new Dictionary<string, string>();

            while (!name.Equals("stop"))
            {
                email = Console.ReadLine();
                if (!email.EndsWith(".us") && !email.EndsWith(".uk"))
                {

                    if (!nameEmailDict.ContainsKey(name))
                    {
                        nameEmailDict.Add(name, email);
                    }
                    nameEmailDict[name] = email;
                }

                name = Console.ReadLine();
            }
             
            foreach (var item in nameEmailDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}