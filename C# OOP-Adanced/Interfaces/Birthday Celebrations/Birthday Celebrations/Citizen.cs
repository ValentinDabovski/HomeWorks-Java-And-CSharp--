﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Celebrations
{
   public class Citizen : ICitizen
    {
      
        public Citizen(string name,int age,string id,string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthDate;
        }

        public string Name { get; }

        public int Age { get; }

        public string Id { get; }

        public string BirthDate { get; }

       public override string ToString()
       {
           return $"{this.BirthDate}";
       }
    }
}
