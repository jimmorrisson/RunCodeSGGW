using System;

namespace Zadanie7
{
    class Program
    {
        static int Suma2(int a, int n)
        {
            var suma = 0;
            while (n > 0)
            {
                a += 1;
                if (a % 5 == 0 && a % 7 != 0)
                {
                    suma += a;
                }
                n -= 1;
            }
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Suma2(34, 6));
            Console.ReadKey();
        }
    }
}
