using System;

namespace Zadanie1
{
    class Program
    {
        static int SumaWTablicy(int[] tab)
        {
            int suma = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma += tab[i];
            }
            return suma;
        }
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4, 5 };
            Console.WriteLine(SumaWTablicy(tab));
            Console.ReadKey();
        }
    }
}
