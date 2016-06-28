using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Speed_Racing
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] inputLines = Console.ReadLine().Split();
                string model = inputLines[0];
                decimal fuelAmount = decimal.Parse(inputLines[1]);
                decimal fuelConsumedForkm = decimal.Parse(inputLines[2]);

                var car = new Car(model, fuelAmount, fuelConsumedForkm);
                carList.Add(car);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string model = input.Split()[1];
                decimal distanceToTravel = decimal.Parse(input.Split()[2]);

                foreach (var car in carList.Where(x => x.Model == model))
                {
                    try
                    {
                        car.Drive(distanceToTravel);
                    }
                    catch (NotEnoughFuelException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}");
            }
        }
    }
}
