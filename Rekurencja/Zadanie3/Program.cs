using System;

namespace Zadanie3
{
    class Program
    {
        static int Dodaj2(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n < 0)
            {
                return n + Dodaj2(n + 1);
            }
            return n + Dodaj2(n - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Dodaj2(-5));
            Console.ReadKey();
        }
    }
}
