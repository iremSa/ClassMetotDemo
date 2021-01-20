using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "İrem";
            musteri1.Soyadi = "Sarıbıyık";
            musteri1.Yasi = 24;
            musteri1.Telefonumarasi = 05411232456;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "Yılmaz";
            musteri2.Yasi = 26;
            musteri2.Telefonumarasi = 05411232855;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Yasemin";
            musteri3.Soyadi = "Küçükyalı";
            musteri3.Yasi = 30;
            musteri3.Telefonumarasi = 05411246001;

            Musteri[] musteriler = new Musteri[]{ musteri1, musteri2, musteri3 };

            MusteriManager musterimanager = new MusteriManager();
            Console.WriteLine("Eklenen  müşteriler:");

            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            musterimanager.Ekle(musteri3);
            Console.WriteLine(" ");
            Console.WriteLine("Listelenen müşteriler:");
            Console.WriteLine(" ");

            MusteriManager musterimanager2 = new MusteriManager();
            musterimanager.Listele(musteri1);
            musterimanager.Listele(musteri2);
            musterimanager.Listele(musteri3);
            Console.WriteLine(" ");
            Console.WriteLine("Silinen müşteriler:");
            Console.WriteLine(" ");

            MusteriManager musterimanager3 = new MusteriManager();
            musterimanager.Sil(musteri1);
            musterimanager.Sil(musteri2);
            musterimanager.Sil(musteri3);




        }

    }
}