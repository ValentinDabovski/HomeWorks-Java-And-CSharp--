using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FootbalStats
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal payment = decimal.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            int arsenalPoints = 0;
            int chelseaPoints = 0;
            int evertonPoints = 0;
            int liverpoolPoints = 0;
            int manchesterCityPoints = 0;
            int manchesterUnitedPoints = 0;
            int southmptonPoints = 0;
            int totthemPoints = 0;
            int points = 0;

            var pointsForTeams = new List<KeyValuePair<string, int>>();
            {
                
                while (true)
                {
                    if (input[0] == "End")
                    {
                        break;
                    }

                    if (input[1] == "2")
                    {
                        switch (input[2])
                        {
                            case "Arsenal":
                                points += 2;
                                arsenalPoints += points;
                                
                                break;

                            case "Chelsea":
                                points += 2;
                                chelseaPoints += points;
                                
                                break;

                            case "Everton":
                                points += 2;
                                evertonPoints += points;
                                
                                break;

                            case "ManchesterCity":
                                points += 2;
                                manchesterCityPoints += points;
                                
                                break;

                            case "ManchesterUnited":
                                points += 2;
                                manchesterUnitedPoints += points;
                              
                                break;

                            case "Liverpool":
                                points += 2;
                                liverpoolPoints += points;
                                
                                break;

                            case "Southampton":
                                points += 2;
                                southmptonPoints += points;
                                
                                break;

                            case "Tottenham":
                                points += 2;
                                totthemPoints += points;
                               
                                break;
                        }
                        points = 0;
                    }

                    else if (input[1] == "1")
                    {
                        switch (input[0])
                        {
                            case "Arsenal":
                                points += 2;
                                arsenalPoints += points;
                               
                                break;

                            case "Chelsea":
                                points += 2;
                                chelseaPoints += points;
                                
                                break;

                            case "Everton":
                                points += 2;
                                evertonPoints += points;
                               
                                break;

                            case "ManchesterCity":
                                points += 2;
                                manchesterCityPoints += points;
                                
                                break;

                            case "ManchesterUnited":
                                points += 2;
                                manchesterUnitedPoints += points;
                                
                                break;

                            case "Liverpool":
                                points += 2;
                                liverpoolPoints += points;
                              
                                break;

                            case "Southampton":
                                points += 2;
                                southmptonPoints += points;
                               
                                break;

                            case "Tottenham":
                                points += 2;
                                totthemPoints += points;
                                
                                break;
                        }

                        points = 0;
                    }

                    else if (input[0] == "X")
                    {
                        points += 1;

                    }
                    points = 0;
                    input = Console.ReadLine().Split(' ');
                }

                var teamsDic = new List<KeyValuePair<string, int>>()
                {
                new KeyValuePair<string, int>("Arsenal",arsenalPoints),
                new KeyValuePair<string, int>("Chelsea", chelseaPoints),
                new KeyValuePair<string, int>("Everton", evertonPoints),
                new KeyValuePair<string, int>("ManchesterCity", manchesterCityPoints),
                new KeyValuePair<string, int>("ManchesterUnited", manchesterUnitedPoints),
                new KeyValuePair<string, int>("Liverpool", liverpoolPoints),
                new KeyValuePair<string, int>("Southampton",southmptonPoints),
                new KeyValuePair<string, int>("Tottenham",totthemPoints)
                };
                
                

                foreach (var team in teamsDic)
                {
                    Console.WriteLine("{0}", team);
                }

                
            }
        }
    }
}