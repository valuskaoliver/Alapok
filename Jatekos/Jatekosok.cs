using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Jatekos
{
    internal class Jatekosok
    {
        private int elet;
        public string Nev { get; set;  }
        public int Elet 
        { 
            get { return elet; }
            set
            {
                if (value < 0) elet = 0;
                else if (value > 100) elet = 100;
                else elet = value;
            }
        }
    }
}
