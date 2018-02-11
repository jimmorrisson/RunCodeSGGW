using System;

namespace Zadanie2
{
    class Program
    {
        static bool CzyDodatniaINieparzysta(int a)
        {
            if (a % 2 != 0 && a % 2 > 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyDodatniaINieparzysta(1));
            Console.ReadKey();
        }
    }
}
