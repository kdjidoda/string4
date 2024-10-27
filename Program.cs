using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Traženje unosa od korisnika
            Console.WriteLine("Unesite niz znakova:");
            string unos = Console.ReadLine();

            // Zamjena razmaka znakom '_'
            string rezultat = unos.Replace(' ', '_');

            // Ispis rezultata
            Console.WriteLine("Niz nakon zamjene razmaka: " + rezultat);
        }
    }
}
