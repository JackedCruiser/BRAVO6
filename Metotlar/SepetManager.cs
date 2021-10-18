using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product ekliUrun)
        {
            Console.WriteLine("Başarılı: " + ekliUrun.Adi + " sepete eklendi!");
            Console.WriteLine("Ekli ürün resim Id:" + ekliUrun.Id);

            int kalanurun = ekliUrun.StokAdeti - 5;
            Console.WriteLine("Kalan stok:" + kalanurun);
        }

       // public void Ekle2(string Adi, string Aciklama)
     //   {
    //        Console.WriteLine(Adi, Aciklama);
    //    }
        
    }
}
