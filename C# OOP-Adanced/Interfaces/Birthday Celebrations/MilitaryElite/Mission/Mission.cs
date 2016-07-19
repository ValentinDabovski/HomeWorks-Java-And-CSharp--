using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Mission : IMission
    {

        public Mission()
        {
            
        }

        public string CodeName { get; }
        public string MissionState { get; }

        

        public void MissionComplete()
        {
            throw new NotImplementedException();
        }
    }
}
