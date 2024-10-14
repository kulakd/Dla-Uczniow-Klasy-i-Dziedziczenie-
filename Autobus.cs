using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaIObiekty2
{
    public class Autobus : Pojazd
    {     
        int IloscOsob;
        public Autobus(int mocsilnika, string kolor, string marka, int iloscOsob) : base(mocsilnika,kolor,marka)
        {
            IloscOsob = iloscOsob;
        }
        // override umożliwia nadpisanie metody bazowej
        public override void UruchomSilnik()
        {
            Console.WriteLine("Uruchomiłem silnik autobusu");
        }
    }
}
