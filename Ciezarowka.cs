using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaIObiekty2
{
    public class Ciezarowka : Pojazd
    {
        double LadownoscNaczepy;
        public Ciezarowka(int mocsilnika, string kolor, string marka, double ladownoscNaczepy) : base(mocsilnika, kolor, marka)
        {
            LadownoscNaczepy = ladownoscNaczepy;
        }
    }
}
 