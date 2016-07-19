using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    interface IEngineer: IPrivate,IRepair
    {
        void AddReapirSet(IRepair repairSet);
    }
}
