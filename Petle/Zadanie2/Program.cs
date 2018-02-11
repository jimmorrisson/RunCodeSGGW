using System;

namespace Zadanie2
{
    class Program
    {
        static int SumaB(int a, int b)
        {
            int x = a + 1;
            int suma = 0;

            while (x < b)
            {
                if (x % 2 != 0)
                {
                    suma += x;
                }
                x += 1;
            }
            return suma;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SumaB(-5, -1));
            Console.ReadKey();
        }
    }
}
