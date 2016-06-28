using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;
using Problem_7.Car_Salesman;

public class Car
{
    

    public Car(string carModel, Engine engine)
    {
        this.CarModel = carModel;
        this.Engine = engine;

    }

    public Engine Engine { get; set; }
    public string CarModel { get; set; }
    public int Weight { get; set; } = 0;
    public string Color { get; set; } = "n/a";

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"{this.CarModel}:");
        stringBuilder.AppendLine($"{this.Engine}");
        stringBuilder.AppendLine(this.Weight == 0 ? "  Weight: n/a" : $"  Weight: {this.Weight}");
        stringBuilder.Append($"  Color: {this.Color}");
        return stringBuilder.ToString();
    }
}

