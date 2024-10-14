using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaIObiekty2
{
    // Jak tworzymy klase
    public class Uczen
    {
        // definiujemy pola klasy
        public string Imie;
        public string Nazwisko;
        public string Dom;
        public double Wzrost;
        public string Różdżka;
        public int wiek;

        // Konstruktor argumentowy -> przy tworzeniu obiektu klasy nadajemy mu konkretne wartości
        public Uczen(string imie, string nazwisko, string dom, double wzrost, string różdżka, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Dom = dom;
            Wzrost = wzrost;
            Różdżka = różdżka;
            this.wiek = wiek;
        }
        // konstruktor domyślny -> przy tworzeniu obiektu klasy automatycznie dobiera wartości pól (null, 0 lub pusty)
        public Uczen() { }

        // Metody klasy
        public void Przedstaw()
        {
            Console.WriteLine($"Nazywam się {Imie} {Nazwisko}. Mam {wiek} lat. Należę do {Dom} i mam {Różdżka}");
        }

        public void ZmienDom(string nowyDom)
        {
            Console.WriteLine($"Należałem do {Dom}");
            Dom = nowyDom;
            Console.WriteLine($"Teraz należę do {Dom}");
        }

         

    }
}
