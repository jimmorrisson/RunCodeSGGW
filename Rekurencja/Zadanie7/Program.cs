using System;

namespace Zadanie7
{
    class Program
    {
        static long PomnozNiepodzielne(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1 || n == -1)
            {
                return n;
            }
            if (n > 0)
            {
                if (n % 7 != 0 && n % 5 != 0)
                {
                    return n * PomnozNiepodzielne(n - 1);
                }
                return PomnozNiepodzielne(n - 1);
            }
            if (n < 0 && n % 7 != 0 && n % 5 != 0)
            {
                return n * PomnozNiepodzielne(n + 1);
            }
            return PomnozNiepodzielne(n + 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PomnozNiepodzielne(-12));
            Console.ReadKey();
        }
    }
}
