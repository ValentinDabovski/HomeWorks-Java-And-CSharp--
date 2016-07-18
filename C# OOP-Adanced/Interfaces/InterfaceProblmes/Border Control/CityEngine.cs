using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Border_Control
{
    public class CityEngine
    {
        public void Run()
        {
            string inputCitizenOrRobots = Console.ReadLine();
            City city = new City();

            while (!inputCitizenOrRobots.Equals("End"))
            {
                string[] splitCitizens = inputCitizenOrRobots.Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);

                if (splitCitizens.Length == 3)
                {
                    ICitizen citizen = new Citizen(splitCitizens[0], int.Parse(splitCitizens[1]), splitCitizens[2]);
                    city.AddCitizen(citizen);

                }

                if (splitCitizens.Length == 2)
                {
                    IRobot robot = new Robot(splitCitizens[0], splitCitizens[1]);
                    city.AddCitizen(robot);
                }

                inputCitizenOrRobots = Console.ReadLine();
            }

            string detainedId = (Console.ReadLine());

            foreach (var robot in city.Citizens)
            {
                char[] takeLastThreeNumbers = robot.Id.Skip(robot.Id.Length - 3).ToArray();
                string lastIdNumbers = new string(takeLastThreeNumbers);
                if (lastIdNumbers == detainedId)
                {
                    Console.WriteLine(robot);
                }
            }
        }
    }
}
