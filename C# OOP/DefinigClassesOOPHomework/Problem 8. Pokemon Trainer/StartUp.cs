using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Problem_8.Pokemon_Trainer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string gatheringInputLines = Console.ReadLine();
            List<Trainer> uniqueTrainers = new List<Trainer>();
            
            while (!gatheringInputLines.Equals("Tournament"))
            {
                // TODO: implement pokemon gathering 
                string[] splitInput = gatheringInputLines.Split();
                string trainerName = splitInput[0];
                Trainer trainer = null;
                trainer = null;
                var pokemon = new Pokemon(splitInput[1], splitInput[2], int.Parse(splitInput[3]));
                if (uniqueTrainers.All(x => x.Name != trainerName))
                {
                    trainer = new Trainer(trainerName);
                    uniqueTrainers.Add(trainer);
                }

                trainer = uniqueTrainers.FirstOrDefault(x => x.Name == trainerName);
                trainer.PokemonsList.Add(pokemon);

                gatheringInputLines = Console.ReadLine();
            }

            string tournamentInputLines = Console.ReadLine();

            while (!tournamentInputLines.Equals("End"))
            {
                // TODO: Implement battle logic

                foreach (var trainer in uniqueTrainers)
                {
                    if (trainer.PokemonsList.Count(x => x.Element == tournamentInputLines) > 0)
                    {
                        trainer.NumberOfBadges++;
                    }

                    else
                    {
                        trainer.PokemonsList.ForEach(x => x.Health -= 10);

                        if (trainer.PokemonsList.Any(x=> x.Health <=0))
                        {
                            trainer.PokemonsList.RemoveAll(x => x.Health <= 0);
                        }          
                    }
                }
                tournamentInputLines = Console.ReadLine();
            }
            
            foreach (var trainer in uniqueTrainers.OrderByDescending(x=> x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.PokemonsList.Count}");
            }      
        }
    }
}

