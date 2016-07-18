using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Border_Control
{
    public class Citizen : ICitizen
    {

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }


        public string Name { get; }

        public int Age { get; }

        public string Id { get; }


        public override string ToString()
        {
            return $"{this.Id}";
        }
    }
}
