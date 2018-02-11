﻿using System;

namespace Zadanie8
{
    class Program
    {
        static char[] ZwrocLiterki(string tekst)
        {
            int rozmiarTab = 0;

            for (int i = 0; i < tekst.Length; i++)
            {
                if ((tekst[i] >= 65 && tekst[i] <= 90) || (tekst[i] >= 97 && tekst[i] <= 122))
                {
                    rozmiarTab += 1;
                }
            }

            char[] tab = new char[rozmiarTab];
            int licznik = 0;
            for (int j = 0; j < tekst.Length; j++)
            {
                if ((tekst[j] >= 65 && tekst[j] <= 90) || (tekst[j] >= 97 && tekst[j] <= 122))
                {
                    tab[licznik] = tekst[j];
                    licznik += 1;
                }
            }
            return tab;
        }
        static void Main(string[] args)
        {
            var a = ZwrocLiterki("Ala Ma Kota");
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
