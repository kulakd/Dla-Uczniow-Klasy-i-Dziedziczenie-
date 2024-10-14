using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaIObiekty2
{
    // klasa Samochód dziedziczy wszystko po klasie bazowej Pojazd
    public class Samochód : Pojazd
    {   
        public Samochód(int mocsilnika, string kolor, string marka) : base(mocsilnika,kolor,marka){}

        // override umożliwia nadpisanie metody bazowej
        public override void UruchomSilnik()
        {
            Console.WriteLine("Uruchomiłem silnik samochodu");
        }
    }  
}
