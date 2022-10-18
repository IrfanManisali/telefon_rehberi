using System;

namespace telefon_rehberi{
    class Program {
        // Main Method
        static public void Main(String[] args)
        {
            Kisi kisi1 = new Kisi("Ahmet","Manisalı","000");
            Kisi kisi2 = new Kisi("İrfan","Manisalı","111");
            Kisi kisi3 = new Kisi("Zübeyde","Manisalı","222");

            List<Kisi> varolanListe = new List<Kisi>();
            varolanListe.Add(kisi1);
            varolanListe.Add(kisi2);
            varolanListe.Add(kisi3);

            Rehber rehber = new Rehber(varolanListe);

            rehber.Basla();

            Console.ReadLine();
        }
    }
}
