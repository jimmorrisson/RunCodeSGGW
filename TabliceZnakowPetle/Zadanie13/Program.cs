using System;

namespace Zadanie13
{
    class Program
    {
        static bool SprawdzCzyWTablicy(string[] tab, string wyraz)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == wyraz)
                    return true;
            }
            return false;
        }
        static string[] UsunDuplikaty(string[] wyrazy)
        {
            try
            {
                int duplikaty = 0;
                for (int i = 0; i < wyrazy.Length; i++)
                {
                    for (int j = i + 1; j < wyrazy.Length; j++)
                    {
                        if (wyrazy[j] == wyrazy[i])
                            duplikaty++;
                    }
                }
                string[] tab = new string[wyrazy.Length - duplikaty];
                int licznik = 0;
                for (int k = 0; k < tab.Length; k++)
                {
                    if (k == 0)
                    {
                        tab[licznik] = wyrazy[k];
                        licznik++;
                    }

                    if (!SprawdzCzyWTablicy(tab, wyrazy[k]))
                    {
                        tab[licznik] = wyrazy[k];
                        licznik++;
                    }
                }
                return tab;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            string[] x = { "" };
            return x;
        }
        static void Main(string[] args)
        {
            string[] x = { "ala", "ula", "ela" };
            var a = UsunDuplikaty(x);
            Console.ReadKey();
        }
    }
}
