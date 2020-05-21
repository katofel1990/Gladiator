using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    public abstract class Abstract : IView
    {

        public abstract string Name { get; }
        public int Hp { get; set; }
        public int Sp { get; set; }
        public int Dex { get; set; }
        public int Lvl { get; set; }

        public abstract void Display();
        
        public abstract void NextLevel();

        

    }
}
