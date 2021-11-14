using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MojaAplikacija
{
    class Program
    {
        const int BROJ_ULAZA = 6; // Koristiti konstante umjesto brojeva u kodu (magic numbers).
        static void Main(string[] args)
        {
            string ulaz;
            int[] brojevi;
            do
            {
                Console.WriteLine("Unesite niz od {0} brojeva odvojenih zarezom. Unesite q za prekid programa.", BROJ_ULAZA);
                ulaz = Console.ReadLine();
                if (ulaz == "q")
                {
                    return;
                }
            } while (!validirajUlaz(ulaz, out brojevi));
            string neparnihBrojeva = imaNeparnih(brojevi) ? "ima" : "nema";
            string brojeviPozitivni = sviPozitivni(brojevi) ? "jesu" : "nisu";
            Console.WriteLine("Brojevi u nizu " + brojeviPozitivni + " svi pozitivni.");
            Console.WriteLine("U nizu " + neparnihBrojeva + " neparnih brojeva.");
            // Ne zatvarati konzolu odmah po zavrsetku programa.
            Console.ReadLine();
        }
        static bool validirajUlaz(string ulaz, out int[] brojevi)
        {
            brojevi = new int[BROJ_ULAZA];
            string[] ulazi = ulaz.Split(',');
            if (ulazi.Length != BROJ_ULAZA) // Korisnicki ulaz nije ispravan.
            {
                Console.WriteLine("Ulaz nije ispravan. Potrebno je unijeti 6 brojeva. Pokusajte ponovo.\n");
                return false;
            }
            for (int i = 0; i < BROJ_ULAZA; i++)
            {
                if (!Int32.TryParse(ulazi[i], out brojevi[i]))
                {
                    // Ulaz nije broj.
                    Console.WriteLine("Ulaz {0} nije ispravan broj.", ulazi[i]);
                    return false;
                }
            }
            return true;
        }
        static bool sviPozitivni(int[] brojevi)
        {
            foreach (int broj in brojevi)
            {
                if (broj <= 0)
                {
                    return false;
                }
            }
            return true;
        }
        static bool imaNeparnih(int[] brojevi)
        {
            foreach (int broj in brojevi)
            {
                if (broj % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}