using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


            Product bardak = new Product();
            bardak.Adi = "Bardak";
            bardak.Fiyat = 10;
            bardak.Aciklama = "10 adet";
            bardak.Id = 15;
            bardak.StokAdeti = 20000;

            Product tabak = new Product();
            tabak.Adi = "Tabak";
            tabak.Fiyat = 15;
            tabak.Aciklama = "6'lı";
            tabak.Id = 08;
            tabak.StokAdeti = 15000;


            //Product[] products = new Product[] {bardak, tabak};

           // foreach (var urun in products)
         //   {
           //     Console.WriteLine(urun.Adi);
          //      Console.WriteLine(urun.Fiyat);
           //     Console.WriteLine(urun.Aciklama);
            //    Console.WriteLine("------------");
           // }

            Console.WriteLine("---Metotdes----");

            //instance

            SepetManager sM = new SepetManager();
            sM.Ekle(bardak);
            sM.Ekle(tabak);

            // sM.Ekle2("Armut", "Yeşil Armut");
            
            
        }
    }
}
