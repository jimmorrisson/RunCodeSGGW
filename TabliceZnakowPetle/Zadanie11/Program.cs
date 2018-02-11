using System;

namespace Zadanie11
{
    class Program
    {
        static bool SprawdzCzyPallindrom(string wyraz)
        {
            for (int i = 0; i < wyraz.Length; i++)
            {
                if (wyraz[i] != wyraz[wyraz.Length - (i + 1)])
                    return false;
            }
            return true;
        }

        static uint IlePalindromowWTablicy(string[] wyrazy)
        {
            uint licznik = 0;
            for (int i = 0; i < wyrazy.Length; i++)
            {
                if (SprawdzCzyPallindrom(wyrazy[i]))
                {
                    licznik++;
                }
            }
            return licznik;
        }
        static void Main(string[] args)
        {
            string[] tab = { "ala", "aka", "dsakldasl", "alla", "lllsdfsadas" };
            uint ile = IlePalindromowWTablicy(tab);
            Console.WriteLine(ile);
            Console.ReadKey();
        }
    }
}
