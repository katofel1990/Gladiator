using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    static class Util
    {
        static public int GetNumber(int min, int max) 
        {
            Random random = new Random();
            int num = random.Next(min, max);
            return num;
        }

        static public int GetNumber(int min, int max, int o)
        {
            Random random = new Random();
            int num = random.Next(min, max);
            while (num == o)
            {
                num = random.Next(min, max);
            }
            return num;
        }

        static public List<Gladiator> CreateNewGladiators(int num)
        {
            List<Gladiator> gladiators = new List<Gladiator>();
            for (int i = 0; i < num; i++)
            {
                int ran = Util.GetNumber(0, 5);
                if (ran == 0)
                {
                    gladiators.Add(new Brutal());
                }
                else if (ran == 1)
                {
                    gladiators.Add(new Archer());
                }
                else if (ran == 2)
                {
                    gladiators.Add(new Assassin());
                }
                else
                {
                    gladiators.Add(new Swordsman());
                }
            }
            return gladiators;
        }

    }
}
