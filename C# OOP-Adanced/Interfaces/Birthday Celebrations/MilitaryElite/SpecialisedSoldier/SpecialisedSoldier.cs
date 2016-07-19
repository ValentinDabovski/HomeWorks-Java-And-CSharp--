using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
   public  class SpecialisedSoldier: Soldier,ISpecialisedSoldier
    {

       public SpecialisedSoldier()
       {
           
       }

       public string SpecialSoldierType { get; set; }
    }
}
