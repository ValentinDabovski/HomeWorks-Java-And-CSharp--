using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Raw_Data
{
    class Car
    {
        private string model;
        private Engine engine;
        private List<Tire> tires = new List<Tire>();
        private Cargo cargo;

        public Car(string model,Engine engine,Cargo cargo)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
        }

        public string Model => model;
        public Engine Engine => engine;
        public List<Tire> Tires => tires;
        public Cargo Cargo => cargo;
    }
}
