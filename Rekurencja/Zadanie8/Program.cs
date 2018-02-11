using System;

namespace Zadanie8
{
    class Program
    {
        static bool CzyJest(int a, int b)
        {
            if (a > b)
            {
                return false;
            }
            if (a % 3 == 0 && a % 5 == 0)
            {
                return true;
            }
            return CzyJest(a + 1, b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyJest(3, 21));
            Console.ReadKey();
        }
    }
}
