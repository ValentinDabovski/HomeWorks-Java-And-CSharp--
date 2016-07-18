using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Celebrations
{
    public class Engine
    {
       public void Run()
        {
            string input = Console.ReadLine();
            ICity city = new City();

            while (!input.Equals("End"))
            {
                string[] splittedInput = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (splittedInput.Length == 5)
                {
                    ICitizen citizen = new Citizen(splittedInput[1], int.Parse(splittedInput[2]), splittedInput[3], splittedInput[4]);
                    city.AddCitizen(citizen);
                }

                if (splittedInput.Length == 3)
                {
                    if (splittedInput[0].Contains("Robot"))
                    {
                        IRobot robot = new Robot(splittedInput[1], splittedInput[2]);
                    }
                
                    else
                    {
                        IPet pet = new Pet(splittedInput[1], splittedInput[2]);
                        city.AddCitizen(pet);
                    }
                }

                input = Console.ReadLine();
            }

            string dateToCheck = Console.ReadLine();
            
            foreach (var citizen in city.AllCitizens())
            {
                string citizenYear = GetYearFromDateBirth(citizen);

                if (citizenYear == dateToCheck)
                {
                    city.AddEqualBirthDate(citizen);
                    Console.WriteLine(citizen);
                }

                else
                {
                    city.AddNotEqualBirthDates(citizen);
                }

                if (city.AllEqualBirthDayDates().Count() == 0)
                {
                    Console.WriteLine("<no output>");
                    break;
                }
            }
        }
        public  string GetYearFromDateBirth(ICheckable citizen)
        {
            var lastFourDigitsFromString = citizen.BirthDate.Skip(citizen.BirthDate.Length - 4).ToArray();
            string citizenYear = new string(lastFourDigitsFromString);
            return citizenYear;
        }
    }
}
