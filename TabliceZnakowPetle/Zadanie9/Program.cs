using System;

namespace Zadanie9
{
    class Program
    {
        static string[] ZwrocWyrazy1(string tekst)
        {
            int licznik = 0;
            int rozmiarTab = 0;
            bool wyraz = false;
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] != ' ')
                {
                    wyraz = true;
                }
                else
                {
                    if (wyraz)
                        rozmiarTab++;
                    wyraz = false;
                }
            }
            if (wyraz)
                rozmiarTab++;
            wyraz = false;
            string[] wyrazyTab = new string[rozmiarTab];
            int pomocnicza = 0;
            string tmp = "";
            for (int j = 0; j < tekst.Length; j++)
            {
                if (tekst[j] != ' ')
                {
                    licznik++;
                    wyraz = true;
                }
                else
                {
                    if (wyraz)
                    {
                        for (int k = 0; k < licznik; k++)
                        {
                            tmp += tekst[j - licznik + k];
                        }
                        wyrazyTab[pomocnicza] += tmp;
                        pomocnicza++;
                        wyraz = false;
                    }
                    if (!wyraz)
                    {
                        licznik = 0;
                        tmp = "";
                    }
                }
            }

            if (wyraz)
            {
                for (int k = 0; k < licznik; k++)
                {
                    tmp += tekst[tekst.Length - (licznik) + k];
                }
                wyrazyTab[pomocnicza] += tmp;
                pomocnicza++;
            }

            return wyrazyTab;
        }
        static void Main(string[] args)
        {
            ZwrocWyrazy1("bla bla bla");
            Console.ReadKey();
        }
    }
}
