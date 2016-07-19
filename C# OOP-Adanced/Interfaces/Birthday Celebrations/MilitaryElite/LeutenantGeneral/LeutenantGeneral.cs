using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    class LeutenantGeneral : Soldier,IPrivate,ILeutenantGeneral
    {
        private List<IPrivate> privatesList;

        public LeutenantGeneral()
        {
            this.privatesList = new List<IPrivate>();
        }

        public double Salary { get; }


        public void AddPrivate(IPrivate privateSoldier)
        {
            this.privatesList.Add(privateSoldier);
        }
    }
}
