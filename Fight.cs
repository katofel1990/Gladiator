using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Gladiator
{
    public static class Fight
    {
        public static int FightOfTwoGladiators(Gladiator first, Gladiator second)
        {
            string firstStats = first.Name + " is " + first.type + "(" + first.Hp + "/" + first.Sp + "/" + first.Dex + "/" + first.Lvl + ")";
            string secondStats = second.Name + " is " + second.type + "(" + second.Hp + "/" + second.Sp + "/" + second.Dex + "/" + second.Lvl + ")";
            Console.WriteLine(firstStats + " vs " + secondStats);
            int tempHpFirst = first.Hp;
            int tempHpSecond = second.Hp;
            int dexWhenAtackFirst = HowManyDex(first.Dex, second.Dex);
            int dexWhenAtackSecond = HowManyDex(second.Dex, first.Dex);


            while (tempHpFirst > 1 && tempHpSecond > 1)
            {
                // first attack
                if (IsSuccesAttack(dexWhenAtackFirst))
                {
                    int damage = first.Sp * Util.GetNumber(1, 6) / 10;
                    Console.WriteLine(first.Name + " make " + damage + "dmg, ");
                    tempHpSecond -= damage;
                }
                else
                {
                    Console.WriteLine(first.Name + " miss attack, ");
                }
                // second attack
                if (IsSuccesAttack(dexWhenAtackSecond))
                {
                    int damage = second.Sp * Util.GetNumber(1, 6) / 10;
                    Console.WriteLine(second.Name + " make " + damage + "dmg, ");
                    tempHpFirst -= damage;
                }
                else
                {
                    Console.WriteLine(second.Name + " miss attack, ");
                }
            }

            if (tempHpFirst < 1 && tempHpSecond < 1)
            {
                Console.WriteLine("Draw");
                return 0;
            }
            else if (tempHpFirst > 1)
            {
                Console.WriteLine(first.Name + " Win");
                return 1;
            }
            else if (tempHpSecond > 1)
            {
                Console.WriteLine(second.Name + " Win");
                return 2;
            }
            else
            {
                Console.WriteLine("problem w wlace");
                return 0;
            }

        }

        public static bool IsSuccesAttack(int dex)
        {
            int attack = Util.GetNumber(0, 100);
            if (attack < dex)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int HowManyDex(int attakcer, int deffender)
        {
            int pro = 0;

            if (attakcer > deffender)
            {
                pro = (100 * (attakcer - deffender) / attakcer);
            }
            else if (deffender > attakcer)
            {
                pro = (100 * (attakcer - deffender) / deffender);
            }
            
            int res = 55 + pro;
            
            if (res < 11)
            {
                return 10;
            }
            else if (res > 97)
            {
                return 98;
            }
            else
            {
                return res+1;
            }
        }    
    }
}
