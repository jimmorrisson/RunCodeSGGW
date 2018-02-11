using System;

namespace Zadanie7
{
    class Program
    {
        static bool CzyDwieWTablicy(double[] T, double a)
        {
            int licznik = 0;
            for (int i = 0; i < T.Length; i++)
            {
                if (T[i] == a && i % 2 != 0)
                    licznik++;
            }
            if (licznik == 2)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            double[] tab = { 1, 2, 3, 4, 2, 2 };
            Console.WriteLine(CzyDwieWTablicy(tab, 2));
            Console.ReadKey();
        }
    }
}
