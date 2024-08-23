using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mehmet Akgün
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.Adi = "Mehmet";
            musteri1.Soyadi = "Akgün";
            musteri1.MusteriNo = "12345";
            musteri1.TcNo = "12345678910";


            // Kodlama.io Şirket
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);


        }
    }

}