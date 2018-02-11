using System;

namespace Zadanie12
{
    class Program
    {
        static string[] PodzielNaWyrazy(string tekst)
        {
            int licznik = 0;
            int rozmiarTab = 0;
            bool wyraz = false;
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] >= 'a' && tekst[i] <= 'z')
                {
                    wyraz = true;
                }
                else
                {
                    if (wyraz)
                    {
                        rozmiarTab++;
                        wyraz = false;
                    }
                }
            }
            if (wyraz)
                rozmiarTab++;
            wyraz = false;

            string[] wyrazy = new string[rozmiarTab];
            string tmp = "";
            for (int j = 0; j < tekst.Length; j++)
            {
                if (tekst[j] >= 'a' && tekst[j] <= 'z')
                {
                    wyraz = true;
                    tmp += tekst[j];
                }
                else
                {
                    if (wyraz)
                    {
                        wyrazy[licznik] = tmp;
                        licznik++;
                        wyraz = false;
                    }

                    tmp = "";
                }
            }
            if (wyraz)
                wyrazy[licznik] = tmp;
            return wyrazy;
        }

        static bool CzyPallindrom(string tekst)
        {
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] != tekst[tekst.Length - (i + 1)])
                    return false;
            }
            return true;
        }
        static uint IlePalindromowWNapisie(string tekst)
        {
            uint ile = 0;
            string[] wyrazy = PodzielNaWyrazy(tekst);
            for (int i = 0; i < wyrazy.Length; i++)
            {
                if (CzyPallindrom(wyrazy[i]))
                    ile++;
            }
            return ile;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IlePalindromowWNapisie("aga ,/,. lal  lul xd"));
            Console.ReadKey();
        }
    }
}
