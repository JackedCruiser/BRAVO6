using System;

namespace Donngu
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] liste = new string[] { "m16", "m4a1", "colt45", "m95", "m120", "bayonetta", "minigun"};            
            
            for (int i = 0; i<liste.Length; i++)
            {
                Console.WriteLine(liste[i]);
            }

            foreach (string alet in liste)
            {
                Console.WriteLine(alet);
            }


        }

    }
}
