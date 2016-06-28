using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Raw_Data
{
    class Engine
    {
        private int engineSpeed;
        private int enginePower;

        public Engine(int engineSpeed,int enginePower)
        {
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
        }

        public int EngineSpeed => engineSpeed;
        public int EnginePower => enginePower;

    }
}
