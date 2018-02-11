using System;

namespace Zadanie2
{
    class Program
    {
        static uint IleWyrazow1(string napis)
        {
            uint pomocnicza = 0;
            bool wyraz = false;
            for (int i = 0; i < napis.Length; i++)
            { 
                if(napis[i] != ' ')
                {
                    wyraz = true;
                }
                else
                {
                    if(wyraz == true)
                    {
                        pomocnicza += 1;
                        wyraz = false;
                    }
                }
            }
            if (wyraz)
                pomocnicza += 1;
            return pomocnicza;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IleWyrazow1("bla bla bla"));
            Console.ReadKey();
        }
    }
}
