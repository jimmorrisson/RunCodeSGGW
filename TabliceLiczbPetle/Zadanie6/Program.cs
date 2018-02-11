using System;

namespace Zadanie6
{
    class Program
    {
        static bool CzyWTablicy(int[] T, int a)
        {
            for (int i = 0; i < T.Length; i++)
            {
                if (T[i] == a)
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4 };
            Console.WriteLine(CzyWTablicy(tab, 5));
            Console.ReadKey();
        }
    }
}
