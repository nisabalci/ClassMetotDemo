using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Nisa";
            musteri1.Soyadi = "Balcı";
            musteri1.Yasi = "25";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "Güngör";
            musteri2.Yasi = "32";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ahmet";
            musteri3.Soyadi = "Yılmaz";
            musteri3.Yasi = "45";


            Console.WriteLine("\n-------Müşteri Takip Sistemi-------\n");

            //Ekleme
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.musteriEkle(musteri1);

            //Silme
            musteriManager.musteriSil(musteri2);

            //Listeleme
            Console.WriteLine("\nMüşteriler Listelendi :\n");
            musteriManager.musteriListele(musteri1);
            musteriManager.musteriListele(musteri2);
            musteriManager.musteriListele(musteri3);



        }
    }
}
