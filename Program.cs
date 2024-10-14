namespace KlasaIObiekty2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Uczen U1 = new Uczen("Jan", "Kowalski", "Ravenclaw", 170, "Mam", 15);
            Uczen U2 = new Uczen("Andrzej", "Nowak", "Slytherin", 152, "Ukradli", 16);
            U1.Przedstaw();
            U2.ZmienDom("Ravenclaw");
            U2.Przedstaw();
            Samochód samochod = new Samochód(90, "Czarny", "Wolkswagen");
            Autobus autobus = new Autobus(200, "Biały", "Solaris", 90);
            Ciezarowka ciezarowka = new Ciezarowka(1000, "Czerwony", "RAM", 10);
            samochod.UruchomSilnik();
            autobus.UruchomSilnik();
            ciezarowka.UruchomSilnik();
            Console.WriteLine("To jest ToString(): " + samochod.ToString());
            Console.WriteLine("To jest GetHashCode(): " + samochod.GetHashCode());
            Console.WriteLine("To jest GetType(): " + samochod.GetType());
            Console.ReadKey();  
        }
    }
}