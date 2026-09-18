using System;
using System.Collections.Generic;
using System.Text;

namespace Valuta
{
    internal class ValutaValto
    {
        public double Arfolyam;
        public double EurorolHuf(double euro)
        {
            return euro * Arfolyam;
        }
        public static double FixErorolHuf(double euro) 
        {
            return euro * 400;
        }
    }
}
