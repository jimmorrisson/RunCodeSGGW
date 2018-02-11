using System;

namespace Zadanie9
{
    class Program
    {
        static int[] WiekszeOdSredniej(int[] tab)
        {
            float suma = 0;
            int licznik = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma += tab[i];
                licznik++;
            }
            float srednia = suma / licznik;
            int rozmiarTab = 0;
            for (int j = 0; j < tab.Length; j++)
            {
                if (tab[j] > srednia)
                    rozmiarTab++;
            }
            int[] T = new int[rozmiarTab];
            int pomocnicza = 0;
            for (int k = 0; k < tab.Length; k++)
            {
                if (tab[k] > srednia)
                {
                    T[pomocnicza] = tab[k];
                    pomocnicza++;
                }
            }
            return T;
        }
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] wos = WiekszeOdSredniej(tab);
            Console.ReadKey();
        }
    }
}
