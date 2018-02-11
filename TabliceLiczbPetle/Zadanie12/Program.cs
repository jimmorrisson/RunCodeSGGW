using System;

namespace Zadanie12
{
    class Program
    {
        static int[] Uporzadkuj(int[] T)
        {
            for (int i = 0; i < T.Length; i = i + 2)
            {
                for (int j = i + 2; j < T.Length; j = j + 2)
                {
                    if (T[i] < T[j])
                    {
                        int pomocnicza = T[i];
                        T[i] = T[j];
                        T[j] = pomocnicza;
                    }
                }
            }

            for (int i = 1; i < T.Length; i = i + 2)
            {
                for (int j = i + 2; j < T.Length; j = j + 2)
                {
                    if (T[i] > T[j])
                    {
                        int pomocnicza = T[i];
                        T[i] = T[j];
                        T[j] = pomocnicza;
                    }
                }
            }
            return T;
        }

        static void Pokaz(int[] tab)
        {
            for (int i = 0; i < tab.Length; i = i + 2)
            {
                Console.WriteLine("Elementy na indeksach parzystych");
                Console.WriteLine($"tab[{i}]: {tab[i]}");
            }
            for (int i = 1; i < tab.Length; i = i + 2)
            {
                Console.WriteLine("Elementy na indeksach nieparzystych");
                Console.WriteLine($"tab[{i}]: {tab[i]}");
            }
        }

        /*static int[] StworzTab(int n)
        {
            int[] tab = new int[n];
            for (int i = 0; i < tab.Length; i++)
            {
                Random r = new Random();
                Thread.Sleep(10);
                tab[i] = r.Next(1, 1000);
            }
            return tab;
        }*/
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };
            int[] b = Uporzadkuj(a);
            Pokaz(b);
            Console.ReadKey();
        }
    }
}
