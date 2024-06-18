using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PraceSeStringama
{
     class PocetSlov
    {
        public  int Spocitej(string text,string hledej)
        {
            int pocet = 0;

            while (text.IndexOf(hledej) != -1)
            {
                pocet++;

                text = text.Remove(text.IndexOf(hledej), hledej.Length);

            }

            return pocet;
        }
    }
}
