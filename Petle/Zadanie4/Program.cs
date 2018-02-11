using System;

namespace Zadanie4
{
    class Program
    {
        static bool CzyIstnieje1(int a, int b)
        {
            var licznik = 2;
            if (a > b)
            {
                return false;
            }
            if (a > -2 && a < 2)
            {
                return true;
            }
            for (int i = 2; i < a; i++)
            {
                if (a % i != 0)
                {
                    licznik += 1;
                }
            }
            if (licznik == a)
            {
                return true;
            }
            return CzyIstnieje1(a + 1, b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyIstnieje1(14, 17));
            Console.ReadKey();
        }
    }
}
