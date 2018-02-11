using System;

namespace Zadanie6
{
    class Program
    {
        static bool CzyJest1(char x, char y, string napis)
        {
            int licznik = 0;
            for (int i = 0; i < napis.Length - 1; i++)
            {
                if (napis[i] == x && napis[i + 1] == y)
                {
                    licznik += 1;
                }
            }
            if (licznik == 2)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyJest1('a', 'b', "abbab"));
            Console.ReadKey();
        }
    }
}
