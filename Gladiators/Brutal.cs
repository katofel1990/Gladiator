using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    public class Brutal : Gladiator
    {
        public Brutal()
        {
            mHp = 1.25;
            mSp = 1.25;
            mDex = 0.75;
            type = "brutal";
            baseStats();
            updateStats();
        }
    }
}
