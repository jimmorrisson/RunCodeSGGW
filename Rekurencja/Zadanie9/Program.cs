using System;

namespace Zadanie9
{
    class Program
    {
        static bool CzySasiaduj(int a, int b)
        {
            var x = a;
            var y = a + 1;

            if (a == b)
            {
                return false;
            }

            if (a == 0 || b == 0)
            {
                return true;
            }

            if (x % 5 == 0 && y % 3 == 0)
            {
                return true;
            }

            return CzySasiaduje(a + 1, b);
        }

        static bool CzySasiaduje(int a, int b)
        {
            if (a > b)
            {
                return false;
            }
            if ((a % 5 == 0 && (a + 1) % 3 == 0) || (a % 3 == 0 && (a + 1) % 5 == 0) && (a + 1) <= b)
            {
                return true;
            }
            return CzySasiaduje(a + 1, b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzySasiaduje(8, 10));
            Console.ReadKey();
        }
    }
}
