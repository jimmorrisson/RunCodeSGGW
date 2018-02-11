using System;

namespace Zadanie4
{
    class Program
    {
        static long Pomnoz(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            if (n == -1)
            {
                return -1;
            }
            if (n < 0)
            {
                return n * Pomnoz(n + 1);
            }
            return n * Pomnoz(n - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Pomnoz(-2));
            Console.ReadKey();
        }
    }
}
