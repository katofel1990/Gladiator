using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    class Archer : Gladiator
    {
        public Archer()
        {
            mHp = 1.25;
            mSp = 1;
            mDex = 1;
            type = "archer";
            baseStats();
            updateStats();
        }
    }
}
