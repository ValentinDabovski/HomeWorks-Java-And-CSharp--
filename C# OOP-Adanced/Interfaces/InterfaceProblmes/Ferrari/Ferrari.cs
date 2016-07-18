
using System;
using System.Text;

namespace Cars
{
   public class Ferrari : ICar
   {
       private const string ModelName = "488-Spider";

       public Ferrari(string driverName)
       {
           this.Model = ModelName;
           this.DriverName = driverName;
       }

       public string Model { get; }

       public string DriverName { get; }

       public string Brake()
       {
           return "Brakes!";
       }

       public string Gas()
       {
           return "Zadu6avam sA!";
       }

       public override string ToString()
       {
           StringBuilder stringBuilder = new StringBuilder();
           stringBuilder.Append($"{this.Model}/{this.Brake()}/{this.Gas()}/{this.DriverName}");
           return stringBuilder.ToString();
       }
   }
}
