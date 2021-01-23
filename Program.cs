using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";
            string[] meyveler = new string[] { };
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 10;
            urun2.Aciklama = "Diyarbakır karpuzu";
            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach(Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine( "!------!");

            }
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);


        }
    }
}
