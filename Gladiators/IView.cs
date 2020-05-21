using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gladiator
{
    public interface IView
    {
        public string Name { get; }
        public int Hp { get; set; }
        public int Sp { get; set; }
        public int Dex { get; set; }
        public int Lvl { get; set; }

        void Display();
        void NextLevel();
        
        
    }
}
