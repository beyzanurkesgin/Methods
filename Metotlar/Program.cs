using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
          int  fiyati = 15;
            string Aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz"; ;
            urun2.Fiyati = 45;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
              
            //type safe=Tip güvenli

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("............");


            }
            //encapsulation 
            Console.WriteLine(".....Metotlar.......");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut",12,5);
            sepetManager.Ekle2("elma", "Yeşil elma", 12,4);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,7);


        }
    }
}
