using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri M1 = new Musteri();
            Musteri M2 = new Musteri();
            Musteri M3 = new Musteri();
            Musteri M4 = new Musteri();

            M1.isim = "ali";
            M1.soyisim = "yılmaz";
            M1.Id = 123;

            M2.isim = "ahmet";
            M2.soyisim = "yılmaz";
            M2.Id = 345;

            M3.isim = "Murat";
            M3.soyisim = "yılmaz";
            M3.Id = 345;

            M4.isim = "kemal";
            M4.soyisim = "yılmaz";
            M4.Id = 345;

            MusteriManager MM = new MusteriManager();

            MM.Ekle(M1);
            MM.Ekle(M2);
            MM.Ekle(M3);
            MM.Ekle(M4);

            MM.Sil(M4);
            MM.Sil(M1);

            MM.listele();




        }
    }
}
