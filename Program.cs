using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.adi = "Zümra";
            musteri1.soyadi = "Kor";
            musteri1.yas = 22;

            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.adi = "Beyza";
            musteri2.soyadi = "Kara";
            musteri2.yas = 23;

            Musteri musteri3 = new Musteri();
            musteri3.id = 3;
            musteri3.adi = "Melike";
            musteri3.soyadi = "Öz";
            musteri3.yas = 24;
            Convert.ToString(musteri1);

            Musteri[] musteriler = new Musteri [] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriListele(musteriler);

        }
    }
}
