using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    class Engineer:Soldier,IEngineer
    {
        private List<IRepair> repairSetList;

        public Engineer()
        {
            this.repairSetList = new List<IRepair>();
        }

        public string PartName { get; }
        public int HoursWorked { get; }
        public double Salary { get; }

        public void AddReapirSet(IRepair repairSet)
        {
           this.repairSetList.Add(repairSet);
        }

    
    }
}
