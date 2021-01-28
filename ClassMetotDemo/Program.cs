using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string MusteriAdi = "Ayşe";
            string MusteriSoyadi = "Keten";
            int ID1 = 554324868;
            string MusteriAdress = "gsadfgsdfgsdfgsıugdfasgfdfg";


            Musteri musteri1= new Musteri();
            musteri1.Adi= "Ayşe";
            musteri1.Soyadi = "Keten";
            musteri1.Id = 554324868;
            musteri1.Adress= "yakut sk zümrüt cd no43";


            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Beyza";
            musteri2.Soyadi = "kesgin";
            musteri2.Id = 333333333;
            musteri2.Adress = "hakem sk haşi cd no4";



            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine( musteri.Adi );
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Id);
                Console.WriteLine(  musteri.Adress);
                Console.WriteLine("................................");


            }
            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
                


                 


        }

    }
}
