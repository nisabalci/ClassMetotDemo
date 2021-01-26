using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void musteriEkle (Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri eklendi.\n");
        }
        
        public void musteriSil (Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri silindi.\n");
        }

        public void musteriListele (Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + "\n" +
                              musteri.Soyadi + "\n" + musteri.Yasi + "\n");
        }
    }
}
