using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Raw_Data
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carsList = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] inputLines = Console.ReadLine().Split();
               
                Cargo cargo = new Cargo(inputLines[4], int.Parse(inputLines[3]));
                Engine engine = new Engine(int.Parse(inputLines[1]),int.Parse(inputLines[2]));
                Car car = new Car(inputLines[0],engine,cargo);
                car.Tires.Add(new Tire(double.Parse(inputLines[5]),int.Parse(inputLines[6])));
                car.Tires.Add(new Tire(double.Parse(inputLines[7]), int.Parse(inputLines[8])));
                car.Tires.Add(new Tire(double.Parse(inputLines[9]), int.Parse(inputLines[10])));
                car.Tires.Add(new Tire(double.Parse(inputLines[11]), int.Parse(inputLines[12])));
                
                carsList.Add(car);
            }
            string input = Console.ReadLine();

            if (input == "fragile")
            {
                var sorted =
                    carsList.Where(x => x.Cargo.CargoType == "fragile").Where(y => y.Tires.Any(x => x.TirePresure < 1));

                foreach (var car in sorted)
                {
                    Console.WriteLine(car.Model);
                }

            }

            else
            {
                var sorted = carsList.Where(x => x.Cargo.CargoType == "flamable").Where(y => y.Engine.EnginePower > 250);
                foreach (var car in sorted)
                {
                    Console.WriteLine(car.Model); 
                }
            }
        }
    }
}
