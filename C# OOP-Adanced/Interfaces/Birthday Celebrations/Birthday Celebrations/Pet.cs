using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Celebrations
{
    public class Pet : IPet
    {
        public Pet(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            Engine engine = new Engine();
        }

        public string Name { get; }

        public string BirthDate { get; }

        public override string ToString()
        {
            return $"{this.BirthDate}";
        }
    }
}
