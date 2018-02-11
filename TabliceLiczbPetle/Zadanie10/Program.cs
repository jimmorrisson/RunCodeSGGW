using System;

namespace Zadanie10
{
    class Program
    {
        static long[] ScalTablice(long[] T1, long[] T2)
        {
            long[] tab = new long[T1.Length + T2.Length];
            int licznik = 0;
            for (int i = 0; i < T1.Length; i++)
            {
                tab[licznik] = T1[i];
                licznik++;
            }
            for (int j = 0; j < T2.Length; j++)
            {
                tab[licznik] = T2[j];
                licznik++;
            }
            return tab;
        }

        static long[] UporzatkujNiemalejaco(long[] tab)
        {
            long pomocnicza;

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[i])
                    {
                        pomocnicza = tab[i];
                        tab[i] = tab[j];
                        tab[j] = pomocnicza;
                    }
                }
            }
            return tab;
        }

        static long[] Scal(long[] T1, long[] T2)
        {
            long[] T = ScalTablice(T1, T2);
            long[] tab = UporzatkujNiemalejaco(T);
            return tab;
        }
        static void Main(string[] args)
        {
            long[] T1 = { 4, 5, 6, 7, 8 };
            long[] T2 = { 5, 6, 7, 8, 9 };
            long[] tab = Scal(T1, T2);
            Console.ReadKey();
        }
    }
}
