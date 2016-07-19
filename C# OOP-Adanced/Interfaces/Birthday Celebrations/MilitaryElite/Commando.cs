using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
     public class Commando : Soldier,ICommando
     {
         private List<IMission> missionList;

         public Commando()
         {
            this.missionList = new List<IMission>();     
         }


         public void AddMissions(IMission mission)
         {
             this.missionList.Add(mission);
         }
     }
}
