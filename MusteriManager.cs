using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Eklendi" + " -- " + musteri.id + " " + musteri.adi +" " + musteri.soyadi+ " " + musteri.yas);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Silindi" + " -- " + musteri.id + " "+  musteri.adi+" " + musteri.soyadi + " "+ musteri.yas);
        }

        public void MusteriListele(Musteri[] must)
        {
            foreach (var x in must)
            {
                Console.WriteLine("Müşteri Başarıyla Listelendi" + " -- " + x.id + " "+  x.adi +" "+ x.soyadi + x.yas);
            }
        }


    }
}