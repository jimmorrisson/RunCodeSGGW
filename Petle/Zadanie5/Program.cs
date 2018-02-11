using System;

namespace Zadanie5
{
    class Program
    {
        static bool CzyPierwsza(int liczba)
        {
            if (liczba < 2)
            {
                return false;
            }
            for (int i = 2; i < liczba; i++)
            {
                if (liczba % i == 0 && liczba != i)
                    return false;
            }
            return true;
        }
        static bool CzyIstnieje2(int a, int b)
        {
            int licznik = 0;
            for (int i = a; i <= b; i++)
            {
                if (CzyPierwsza(i))
                    licznik++;
            }
            if (licznik == 2)
                return true;

            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyIstnieje2(1, 5));
            Console.ReadKey();
        }
    }
}
