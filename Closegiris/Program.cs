using System;

namespace Closegiris
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 35;

            Kurs kurs1 = new Kurs();
            
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Solid";
            kurs2.Egitmen = "Ahmad";
            kurs2.IzlenmeOrani = 77;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "ANSYS";
            kurs3.Egitmen = "Yalcin";
            kurs3.IzlenmeOrani = 39;


            Console.WriteLine(kurs3.KursAdi+": "+kurs3.Egitmen);


            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (var anan in kurslar)
                Console.WriteLine(anan.KursAdi+": "+anan.Egitmen);
            {

            }
    
        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }
    }

}
