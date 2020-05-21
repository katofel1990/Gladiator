using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    public class Gladiator : Abstract
    {
        private List<string> _names = new List<string>();
        public override string Name { get; }
        internal int  bHp { get; set; }
        internal int bSp { get; set; }
        internal int bDex { get; set; }
        internal double mHp { get; set; }
        internal double mSp { get; set; }
        internal double mDex { get; set; }
        internal string type { get; set; }
        public override void NextLevel()
        {
            Lvl++;
            updateStats();
        }
        public override void Display()
        {
            Console.WriteLine("{0} is a {1} ({2}, {3}, {4}, {5})", Name, type, Hp, Sp, Dex, Lvl);
        }
        private string GetName()
        {
            string newName;           
            do
            {
                int num = Util.GetNumber(0, 11);
                if (num == 10)
                {
                    num = Util.GetNumber(0, 7);
                    newName = _nameS[num];
                }
                else
                {
                    newName = _nameA[num] + " " + _nameB[Util.GetNumber(0, 10)];
                }
            } while (_names.Contains(newName));

            _names.Add(newName);
            return newName;
        }
        public void updateStats()
        {
            this.Hp = Convert.ToInt32(Convert.ToDouble(this.bHp) * this.mHp * Lvl);
            this.Sp = Convert.ToInt32(Convert.ToDouble(this.bSp) * this.mSp * Lvl);
            this.Dex = Convert.ToInt32(Convert.ToDouble(this.bDex) * this.mDex * Lvl);
        }
        public void baseStats()
        {
            this.bHp = Util.GetNumber(50, 101);
            this.bSp = Util.GetNumber(50, 101);
            this.bDex = Util.GetNumber(50, 101);
            this.Lvl = Util.GetNumber(1, 6);
        }

        public Gladiator()
        {
            Name = GetName();
        }

        private protected string[] _nameB = new string[]
        {
            "Leo", "Brutus", "Lyajos", "Spikulus", "Flamma",
            "Hermes", "Pryskus", "Werus", "Scewa", "Bato"
        };
        private protected string[] _nameA = new string[]
        {
            "Agelatus", "Brutal", "Balbin", "Crassus",
            "Flaccus", "Galba", "Kalwus", "Geta", "Grakchus", "Kaligula"
        };
        private protected string[] _nameS = new string[]
        {
            "Maximus Decimus Meridus", "Spartakus", "Hercules",
            "Karpoforos", "The Mountain", "Kratos", "Leonidas"
        };

    }
}
