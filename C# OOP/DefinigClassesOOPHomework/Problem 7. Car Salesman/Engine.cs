using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Car_Salesman
{

    public class Engine
    {
        public Engine(string engineModel, int power)
        {
            this.EngineModel = engineModel;
            this.Power = power;
        }

        public string EngineModel { get; set; } 
        public int Power { get; set; }
        public int Displacement { get; set; } = 0;
        public string Efficienty { get; set; } = "n/a";


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"  {EngineModel}:");
            stringBuilder.AppendLine($"    Power: {this.Power}");
            stringBuilder.AppendLine(this.Displacement == 0 ? "    Displacement: n/a" : $"    Displacement: {this.Displacement}");
            stringBuilder.Append($"    Efficiency: {this.Efficienty}");

            return stringBuilder.ToString();
        }
    }
}
