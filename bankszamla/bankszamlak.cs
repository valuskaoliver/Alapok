using System;
using System.Collections.Generic;
using System.Text;

namespace bankszamla
{
    internal class bankszamlak
    {
        private double egyenleg;
        public void befizetes(double osszeg)
        {
            if (osszeg > 0) 
            {
                egyenleg += osszeg;
            }
            else Console.WriteLine("Nem lehet negativ");
        }
        public void Kivet(double osszeg) 
        {
            if ((osszeg > 0) && egyenleg >= osszeg)
            {
                egyenleg -= osszeg;
            }
            else Console.WriteLine("Nem vehetsz le tobbet ami van");
        }
    }
}
