using System;

namespace Zadanie11
{
    class Program
    {
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
        static bool CzyIstniejaLiczby(int[] T)
        {
            int suma = 0;
            for (int i = 0; i < T.Length; i++)
            {
                for (int j = i + 1; j < T.Length; j++)
                {
                    for (int k = i + 2; k < T.Length; k++)
                    {
                        suma = T[i] + T[j] + T[k];
                        if (CzyPierwsza(suma))
                            return true;
                    }
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] T = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            bool x = CzyIstniejaLiczby(T);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
