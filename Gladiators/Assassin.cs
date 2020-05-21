using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    class Assassin : Gladiator
    {
        public Assassin()
        {
            mHp = 0.75;
            mSp = 1.25;
            mDex = 1.25;
            type = "assasin";           
            baseStats();
            updateStats();
        }
    }
}
