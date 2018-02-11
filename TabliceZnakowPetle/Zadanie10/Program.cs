using System;

namespace Zadanie10
{
    class Program
    {
        static string[] PodzielNaWyrazy(string tekst)
        {
            bool wyraz = false;
            int rozmiarTab = 0;
            for (int i = 0; i < tekst.Length; i++)
            {
                if ((tekst[i] >= 'a' && tekst[i] <= 'z') ||
                    (tekst[i] >= 'A' && tekst[i] <= 'Z'))
                {
                    wyraz = true;
                }
                else
                {
                    if (wyraz)
                    {
                        rozmiarTab++;
                    }
                    wyraz = false;
                }
            }

            if (wyraz)
            {
                rozmiarTab++;
            }

            wyraz = false;
            string[] tab = new string[rozmiarTab];
            string tmp = "";
            int licznik = 0;
            int pomocnicza = 0;

            for (int j = 0; j < tekst.Length; j++)
            {
                if ((tekst[j] >= 'a' && tekst[j] <= 'z') ||
                    (tekst[j] >= 'A' && tekst[j] <= 'Z'))
                {
                    wyraz = true;
                    tmp += tekst[j];
                    pomocnicza++;
                }
                else
                {
                    if (wyraz)
                    {
                        tab[licznik] = tmp;
                        licznik++;
                        tmp = "";
                    }
                    pomocnicza = 0;
                    wyraz = false;
                }
            }

            tmp = "";
            if (wyraz)
            {
                for (int k = 0; k < pomocnicza; k++)
                {
                    tmp += tekst[tekst.Length - (pomocnicza) + k];
                }
                tab[licznik] = tmp;
            }

            return tab;
        }

        static bool CzyWTablicy(string[] tab, string wyraz)
        {
            int licznik = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                if (wyraz != tab[i])
                {
                    licznik++;
                }
            }

            if (licznik == tab.Length)
            {
                return false;
            }

            return true;
        }

        static string[] DodajBezDuplikatow(string[] tab)
        {
            string[] pomocnicza = new string[tab.Length - 1];
            int powtorki = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[i] == tab[j] && i != j)
                    {
                        powtorki++;
                    }
                }
            }

            int rozmiarTab = tab.Length - powtorki + 1;
            string[] zwrot = new string[rozmiarTab];
            int licznik = 0;

            for (int k = 0; k < tab.Length; k++)
            {
                if (!CzyWTablicy(zwrot, tab[k]))
                {
                    zwrot[licznik] = tab[k];
                    licznik += 1;
                }
            }

            return zwrot;
        }

        static string[] ZwrocWyrazy2(string tekst)
        {
            var a = PodzielNaWyrazy(tekst);
            var b = DodajBezDuplikatow(a);
            return b;
        }
        static void Main(string[] args)
        {
            var a = ZwrocWyrazy2("bla bla bla a x");
            Console.ReadKey();
        }
    }
}
