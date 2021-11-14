using System;

namespace BrzinaBroda
{
    class Program
    {
        const int Miles = 1852;
        static void Main(string[] args)
        {
            int brzina;
            decimal rezultat;
            Console.Write("Unesite brzinu broda u cvorovima: ");
            brzina = Convert.ToInt32(Console.ReadLine());
            rezultat = (brzina * Miles) / 1000M;
            Console.WriteLine("Brzina broda u km/h je {0}", rezultat);
            Console.ReadLine();
        }
    }
}