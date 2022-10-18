using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace telefon_rehberi
{
    class Rehber
    {
        private List<Kisi> liste = new List<Kisi>();
        public Rehber()
        {

        }
        public Rehber(List<Kisi> varolanListe)
        {
            liste.AddRange(varolanListe);
        }

        public void Basla()
        {
            basla:


            Console.WriteLine("***** Yapmak İstediğiniz İşlem *****");
            Console.WriteLine("(1) Yeni numara kaydetmek.");
            Console.WriteLine("(2) Varalon numarayı silme.");
            Console.WriteLine("(3) Varalon numarayı güncelle.");
            Console.WriteLine("(4) Rehberi listele.");
            Console.WriteLine("(5) Rehberde arama yap.");

            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                TelNoKayıt();
                break;
                case "2":
                TelNoSil();
                break;
                case "3":
                TelNoGüncelle();
                break;
                case "4":
                RehberListeleme();
                break;
                case "5":
                RehberArama();
                break;
                default:
                goto basla;
                break;
            }

            goto basla;

        }



        public void TelNoKayıt()
        {
            Console.WriteLine("***** Telefon Kayıt *****");
            Console.Write("Ad: ");
            string ad = Console.ReadLine();
            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();
            Console.Write("Telefon No: ");
            string telNo = Console.ReadLine();

            Kisi kisi = new Kisi(ad,soyad,telNo);
            liste.Add(kisi);
        }

        public void TelNoSil()
        {
            Console.WriteLine("***** Telefon Kayıt Silme *****");
            Console.Write("Ad: ");
            string ad = Console.ReadLine();
            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();

            Kisi kisi = ListeKisiBulmaAdSoyad(ad, soyad);
            
            liste.Remove(kisi);
        }
        public void TelNoGüncelle()
        {
            Console.WriteLine("***** Telefon Kayıt Güncelleme *****");
            Console.Write("Ad: ");
            string ad = Console.ReadLine();
            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();
            Console.Write("Telefon No: ");
            string telNo = Console.ReadLine();

            Kisi kisi = ListeKisiBulmaAdSoyad(ad, soyad);
            
            kisi.TelNo = telNo;
        }
        public void RehberListeleme()
        {
            Console.WriteLine("***** Telefon Rehberi *****");

            foreach (var item in liste)
            {
                KisiBilgisiYazdır(item);
            }

        }

        public void RehberArama()
        {
            Console.WriteLine("***** Telefon Rehberi Arama *****");

            Console.Write("Ad: ");
            string ad = Console.ReadLine();
            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();

            Kisi kisi = ListeKisiBulmaAdSoyad(ad, soyad);

            KisiBilgisiYazdır(kisi);

        }

        private void KisiBilgisiYazdır(Kisi kisi)
        {
            Console.WriteLine("********************");
            Console.WriteLine("Ad: " + kisi.Ad);
            Console.WriteLine("Soyad: " + kisi.Soyad);
            Console.WriteLine("Telefon No: " + kisi.TelNo);
        }

        private Kisi ListeKisiBulmaAdSoyad(string ad, string soyad)
        {
            foreach (Kisi item in liste)
            {
                if (item.Ad == ad && item.Soyad == soyad)
                {
                    return item;
                }
            }

            return new Kisi();
        }

    }
}