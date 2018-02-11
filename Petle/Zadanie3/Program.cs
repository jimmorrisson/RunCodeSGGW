using System;

namespace Zadanie3
{
    class Program
    {
        static string ZamienNaDwojkowy(uint n)
        {
            string str = "";
            uint reszta = 0;
            int licznik = 0;
            uint pomocnicza = n;
            while (pomocnicza > 0)
            {
                reszta = n % 2;
                licznik++;
                pomocnicza /= 2;
            }
            for (int i = licznik - 1; i >= 0; i--)
            {
                reszta = n % 2;
                if (reszta != 0)
                    str += reszta;
                if (reszta == 0 && str != "")
                    str += reszta;
                n /= 2;
            }
            if (str == "")
                str += "0";

            return str;
        }
        static void Main(string[] args)
        {
            string a = ZamienNaDwojkowy(254);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
