using System;

namespace Zadanie6
{
    class Program
    {
        static int Suma(int a, int b, int c)
        {
            var wyraz = a;
            var n = 1;
            if (c == 0)
            {
                return 0;
            }
            while (wyraz + c < b)
            {
                n += 1;
                wyraz += c;
            }
            return ((2 * a + (n - 1) * c) / 2) * n;
        }

        static int Suma1(int a, int b, int c)
        {
            int suma = 0;
            for (int i = a; i <= b; i = i + c)
            {
                suma += i;
            }
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Suma1(1, 10, 2));
            Console.ReadKey();
        }
    }
}
