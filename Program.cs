using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Gladiator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Gladiator> gladiators = Util.CreateNewGladiators(16);
            Combat combat = new Combat();
            combat.SimulateTurnament(gladiators);
            
        }
    }
}
