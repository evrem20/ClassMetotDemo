using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Bülent";
            musteri1.MusteriSoyadi = "Kara";
            musteri1.MusteriYasi = 50;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Mehmet";
            musteri2.MusteriSoyadi = "Eren";
            musteri2.MusteriYasi = 39;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Hatice";
            musteri3.MusteriSoyadi = "Yeşil";
            musteri3.MusteriYasi = 35;


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);







        }
    }
}
