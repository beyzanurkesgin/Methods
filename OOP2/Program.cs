using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Beyzanur Kesgin
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = " 1223423";
            musteri1.Adi = "Beyza";
            musteri1.Soyadi = " Kesgin";
            musteri1.TcNo = "232531116275";





            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54783645872";
            musteri2.SirketAdi = "Kodama.İo";
            musteri2.VergiNo = "232143423";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
