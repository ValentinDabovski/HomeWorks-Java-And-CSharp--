using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Spy : Soldier,ISpy
    {
        public Spy()
        {
            
        }

        public int CodeNumber { get; }
    }
}
