using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public abstract class Soldier 
    {
        protected Soldier()
        {

        }

        public string FirstName { get; set; }
        public string LasName { get; set; }
        public string Id { get; set; }
    }
}
