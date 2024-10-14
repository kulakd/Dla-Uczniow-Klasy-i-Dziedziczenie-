using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaIObiekty2
{

    // Klasa Pojazd to klasa bazowa po której będą dziedziczyć inne klasy
    public class Pojazd
    {
        public int MocSilnika;
        public string Kolor;
        public string Marka;


        // konstruktor klasy bazowej
        public Pojazd(int mocsilnika, string kolor, string marka)
        {
            MocSilnika = mocsilnika;
            Kolor = kolor;
            Marka = marka;
        }

        // metoda klasy bazowej
        // jest metoda wirtualną (virtual), aby była możliwość "nadpisania" jej przez metody pochodne
        public virtual void UruchomSilnik()
        {
            Console.WriteLine("Uruchomiłem silnik");
        }
    }
}
