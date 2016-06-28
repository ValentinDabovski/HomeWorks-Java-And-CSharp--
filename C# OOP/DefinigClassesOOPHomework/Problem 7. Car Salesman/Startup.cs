using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Car_Salesman
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engineList = new List<Engine>();
            List<Car> carList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] engineData = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);

               var engine = new Engine(engineData[0],int.Parse(engineData[1]));

                engineList.Add(engine);

                if (engineData.Length == 3)
                {
                    int possibleDisplacementNumber;
                    if (int.TryParse(engineData[2],out possibleDisplacementNumber))
                    {
                        engine.Displacement = possibleDisplacementNumber;
                    }

                    else
                    {
                        engine.Efficienty = engineData[2];
                    }
                }

                if (engineData.Length == 4)
                {
                    engine.Displacement = int.Parse(engineData[2]);
                    engine.Efficienty = engineData[3];
                }
            }

            int y = int.Parse(Console.ReadLine());

            for (int i = 0; i < y; i++)
            {

                string[] carData = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);
                var engine = engineList.FirstOrDefault(x => x.EngineModel == carData[1]);
                var car = new Car(carData[0], engine);
                carList.Add(car);

                if (carData.Length == 3)
                {
                    int possibleWeight;

                    if (int.TryParse(carData[2], out possibleWeight))
                    {
                        car.Weight = possibleWeight;
                    }

                    else
                    {
                        car.Color = carData[2];
                    }
                }

                if (carData.Length == 4)
                {
                    car.Weight = int.Parse(carData[2]);
                    car.Color = carData[3];
                }
              
            }

            foreach (var car in carList)
            {

                Console.WriteLine(car);
            }
        }
    }
}
 