using System;

namespace Zadanie3
{
    class Program
    {
        static bool CzyDodINiepodzPrzez3(int a, int b, int c)
        {
            if ((a > 0 && a % 3 != 0) || (b > 0 && b % 3 != 0) || (c > 0 && c % 3 != 0))
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyDodINiepodzPrzez3(-5, 3, 3));
            Console.ReadKey();
        }
    }
}
