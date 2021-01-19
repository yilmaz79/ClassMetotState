using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassMetotDemo
{
    public class MusteriManager
    {



        List<Musteri> musteriler = new List<Musteri>();


        public void Ekle(Musteri m)
        {


            musteriler.Add(m);

            Console.WriteLine(m.isim +" " + m.soyisim + " " + "eklendi");


        }
        public void listele()
        {
            Console.WriteLine("------musteri listesi----");

            foreach (var item in musteriler)
            {
                Console.WriteLine(item.isim+ " "  + item.soyisim);

            }


        }

        public void Sil(Musteri m)
        {
            musteriler.Remove(m);

            Console.WriteLine(m.isim+ " " + m.soyisim + " " + "silindi");

        }

    }
}
