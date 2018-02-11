using System;

namespace Zadanie7
{
    class Program
    {
        static bool CzyJest2(char x, char y, string napis)
        {
            int licznik = 0;
            for (int i = 0; i < napis.Length - 2; i++)
            {
                if (napis[i] == x && napis[i + 2] == y)
                {
                    licznik += 1;
                }
            }
            if(licznik == 2)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyJest2('x','y', "xxyxx"));
            Console.ReadKey();
        }
    }
}
