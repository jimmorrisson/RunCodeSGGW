using System;

namespace Zadanie5
{
    class Program
    {
        static string ZamienNaMale(string tekst)
        {
            string tmp = "";
            int roznica = 'a' - 'A';
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] <= 90 && tekst[i] >= 65)
                {
                    tmp += (char)(tekst[i] + roznica);
                }
                else
                {
                    tmp += tekst[i];
                }
            }
            return tmp;
        }
        static bool CzyAnagram(string napis1, string napis2)
        {
            bool zawiera = false;
            int licznik = 0;
            if (napis1.Length != napis2.Length)
            {
                return false;
            }

            napis1 = ZamienNaMale(napis1);
            napis2 = ZamienNaMale(napis2);

            for (int i = 0; i < napis1.Length; i++)
            {
                for (int j = 0; j < napis2.Length; j++)
                {
                    if (napis1[i] == napis2[j])
                    {
                        zawiera = true;
                    }
                }
                if (zawiera)
                {
                    licznik += 1;
                }
            }
            if (licznik == napis1.Length)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CzyAnagram("alAl", "alla"));
            Console.ReadKey();
        }
    }
}
