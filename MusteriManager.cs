using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi:" + musteri.Adi +" "+ musteri.Soyadi);
            Console.WriteLine("Müşteri Yaşı:" + musteri.Yasi );
            Console.WriteLine("Müşteri Telefon Numarası:" + musteri.Telefonumarasi);


        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi:" + musteri.Adi+ " "  + musteri.Soyadi);
            
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri listelendi:" + musteri.Adi + " "+ musteri.Soyadi);
           
        }
    }
}
