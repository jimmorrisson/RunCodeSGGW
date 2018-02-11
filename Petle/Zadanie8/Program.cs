using System;

namespace Zadanie8
{
    class Program
    {
        static uint Suma(int a, int b)
        {
            var suma = 0;

            for (int i = a + 1; i < b; i++)
            {
                if (!(i > 1)) { continue; }
                if (i == 2) { suma += 2; }
                else
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0 && i != j)
                        {
                            break;
                        }
                        else if (j + 1 == i)
                        {
                            suma += i;
                        }
                    }
                }
            }
            return (uint)suma;
        }

        static bool CzyPierwsza(int liczba)
        {
            if (liczba < 2)
                return false;
            for (int i = 2; i < liczba; i++)
            {
                if (liczba % i == 0 && liczba != i)
                    return false;
            }
            return true;
        }
        static uint Suma3(int a, int b)
        {
            uint licznik = 0;
            for (int i = a + 1; i < b; i++)
            {
                if (CzyPierwsza(i))
                {
                    licznik++;
                }
            }
            return licznik;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Suma3(1, 2));
            Console.ReadKey();
        }
    }
}
