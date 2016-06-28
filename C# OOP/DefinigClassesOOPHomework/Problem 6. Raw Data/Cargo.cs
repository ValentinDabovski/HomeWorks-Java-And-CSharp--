using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Raw_Data
{
    class Cargo
    {
        private string cargoType;
        private int cargoWeight;

        public Cargo(string cargoType,int cargoWeight)
        {
            this.cargoType = cargoType;
            this.cargoWeight = cargoWeight;
        }

        public string CargoType => cargoType;
        public int CartgoWeight => cargoWeight;
    }
}
