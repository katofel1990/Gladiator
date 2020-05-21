using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Gladiator
{
    public class Combat
    {
        public void SimulateTurnament(List<Gladiator> gladiators)
        {
            int numbersOfGladiators = gladiators.Count;
            int numberOfGladiatorsInNextRound = 2;
            string lineNewRound = "========================================";
            string lineNewFight = "----------------------------------------";
            int round = 1;
            Console.WriteLine("List of all gladiators:");
            for (int i = 0; i < gladiators.Count; i++)
            {
                Console.WriteLine("Gladiator {0}: {1} is {2}({3}/{4}/{5}/{6})",i+1 , gladiators[i].Name, gladiators[i].type, gladiators[i].Hp, gladiators[i].Sp, gladiators[i].Dex, gladiators[i].Lvl);
            }

            while (numberOfGladiatorsInNextRound <= numbersOfGladiators)
            {
                numberOfGladiatorsInNextRound *= 2;
            }
            numberOfGladiatorsInNextRound /= 2;

            while (gladiators.Count > 1)
            {
                Console.WriteLine(lineNewRound);
                
                Console.WriteLine("Round {0} just start", round);

                List<Gladiator> temp = new List<Gladiator>();

                if (gladiators.Count != numberOfGladiatorsInNextRound)
                {
                    int gladiatorWithoutFight = numberOfGladiatorsInNextRound * 2 - gladiators.Count;
                    for (int i = 0; i < gladiatorWithoutFight; i++)
                    {
                        int randomNumber = Util.GetNumber(0, gladiators.Count);
                        temp.Add(gladiators[randomNumber]);
                        gladiators.RemoveAt(randomNumber);
                    }
                }
                
                
                

                

                while (gladiators.Count > 0)
                {
                    int gladiatorNumerOne = Util.GetNumber(0, gladiators.Count);
                    int gladiatorNumerTwo = Util.GetNumber(0, gladiators.Count, gladiatorNumerOne);
                    var gladiatorOne = gladiators[gladiatorNumerOne];
                    var gladiatorTwo = gladiators[gladiatorNumerTwo];
                    Console.WriteLine(lineNewFight);
                    int resoult = Fight.FightOfTwoGladiators(gladiatorOne, gladiatorTwo);
                    if (resoult == 0)
                    {
                        gladiators.Remove(gladiatorOne);
                        gladiators.Remove(gladiatorTwo);
                    }
                    else if (resoult == 1)
                    {
                        temp.Add(gladiatorOne);
                        gladiators.Remove(gladiatorOne);
                        gladiators.Remove(gladiatorTwo);
                    }
                    else
                    {
                        temp.Add(gladiatorTwo);
                        gladiators.Remove(gladiatorOne);
                        gladiators.Remove(gladiatorTwo);
                    }

                }
                
                foreach (var item in temp)
                {
                    gladiators.Add(item);
                }
                temp.Clear();
                round++;
                numberOfGladiatorsInNextRound /= 2;
                foreach (var item in gladiators)
                {
                    item.NextLevel();
                }
            }
            if (gladiators.Count == 1)
            {
                Console.WriteLine("This turnament win {0}", gladiators[0].Name );
            }
            else
            {
                Console.WriteLine("Both gladiators die in final, nobody win");
            }
        }        
    }
}
