using System;

namespace Zadanie8
{
    class Program
    {
        static string DodajTeksty(string tekst1, string tekst2)
        {
            return tekst1 + tekst2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DodajTeksty("progra","mowanie"));
            Console.ReadKey();
        }
    }
}
