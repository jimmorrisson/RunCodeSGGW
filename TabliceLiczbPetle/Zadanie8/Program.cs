using System;

namespace Zadanie8
{
    class Program
    {
        static double[] Ujemne(double[] tab)
        {
            int rozmiarTab = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < 0)
                    rozmiarTab++;
            }
            double[] T = new double[rozmiarTab];
            int licznik = 0;
            for (int j = 0; j < tab.Length; j++)
            {
                if (tab[j] < 0)
                {
                    T[licznik] = tab[j];
                    licznik++;
                }
            }
            return T;
        }
        static void Main(string[] args)
        {
            double[] tab = { -1, -2, 3, 4, 5 };
            var a = Ujemne(tab);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
