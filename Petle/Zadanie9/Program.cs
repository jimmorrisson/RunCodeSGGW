using System;

namespace Zadanie9
{
    class Program
    {
        static double Srednia1(int a, int n)
        {
            double suma = 0;
            int licznik = 0;
            for (int i = a + 1; i <= a + n; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    suma += i;
                    licznik++;
                }
            }
            if (licznik == 0)
                return 0;
            return suma / licznik;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Srednia1(1, 10));
            Console.ReadKey();
        }
    }
}
