using System;
using System.Collections.Generic;
using System.Text;

namespace Konyv
{
    internal class Konyvek
    {
        public string Cim {  get; set; }
        public int Oldalszam { get; set; }
        public int Kiadaseve { get; set; }

        public Konyvek() 
        {

        }
        public Konyvek(string cim)
        {
            Cim = cim;
        }


        public Konyvek(string cim, int oldalszam, int kidaseve)
        {
            Cim = cim;
            Oldalszam = oldalszam;
            Kiadaseve = kidaseve;
        }
        
    }
}
