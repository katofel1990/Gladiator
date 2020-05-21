using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    public class Swordsman : Gladiator
    {
         
        public Swordsman() 
        {
            mHp = 1;
            mSp = 1;
            mDex = 1;
            type = "swordsman";
            baseStats();
            updateStats();
        }

        
        
    }
}
